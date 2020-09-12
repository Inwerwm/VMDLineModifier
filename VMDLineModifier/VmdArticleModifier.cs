using MikuMikuMethods;
using MikuMikuMethods.Vmd;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMDLineModifier
{
    class VmdArticleModifier
    {
        public string FilePath { get; set; }
        public VocaloidMotionData vmd { get; private set; }
        public Dictionary<string, Article> Articles { get; } = new Dictionary<string, Article>();

        public string TypeAndNameOf(FrameType type, IVmdModelFrameData frame) => $"{type.Name()}:{frame.Name}";

        private void MakeArticle(IVmdModelFrameData f, FrameType type)
        {
            Article article = new Article(type, f.Name);

            if (!Articles.ContainsKey(article.ToKey()))
                Articles.Add(article.ToKey(), article);

            Articles[article.ToKey()].Frames.Add(f);
        }

        public void Read(string path)
        {
            using (BinaryReader reader = new BinaryReader(new FileStream(path, FileMode.Open)))
                vmd = new VocaloidMotionData(reader);

            if (vmd.ModelName == VocaloidMotionData.CAMERA_DATA_NAME)
                throw new FormatException();

            FilePath = path;

            // Articlesにフレームを分類して格納
            foreach (var f in vmd.MorphFrames)
            {
                MakeArticle(f, FrameType.Morph);
            }

            foreach (var f in vmd.MotionFrames)
            {
                MakeArticle(f, FrameType.Motion);
            }
        }

        public void Write(string path)
        {
            vmd.MorphFrames.Clear();
            vmd.MotionFrames.Clear();

            vmd.MorphFrames.AddRange(Articles.Where(p => p.Value.Type == FrameType.Morph).SelectMany(p => p.Value.Frames).Cast<VmdMorphFrameData>());
            vmd.MotionFrames.AddRange(Articles.Where(p => p.Value.Type == FrameType.Motion).SelectMany(p => p.Value.Frames).Cast<VmdMotionFrameData>());

            using (BinaryWriter writer = new BinaryWriter(new FileStream(path, FileMode.OpenOrCreate)))
                vmd.Write(writer);

            FilePath = path;
        }
    }
}
