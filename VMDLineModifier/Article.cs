using MikuMikuMethods;
using MikuMikuMethods.Vmd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMDLineModifier
{
    class Article
    {
        private string name;
        public string Name
        {
            get => name; 
            set
            {
                if (!IsModelFrame)
                    return;

                name = value;
                foreach (var f in Frames.Cast<IVmdModelFrameData>())
                {
                    f.Name = name;
                }
            }
        }
        public List<IVmdFrameData> Frames { get; } = new List<IVmdFrameData>();
        public FrameType Type { get; }
        public bool IsModelFrame { get; }

        public Article(FrameType type, string name="")
        {
            Type = type;

            switch (Type)
            {
                case FrameType.Motion:
                    IsModelFrame = true;
                    this.name = name;
                    break;
                case FrameType.Morph:
                    IsModelFrame = true;
                    this.name = name;
                    break;
                case FrameType.Camera:
                    IsModelFrame = false;
                    this.name = "カメラ";
                    break;
                case FrameType.Light:
                    IsModelFrame = false;
                    this.name = "照明";
                    break;
                case FrameType.Shadow:
                    IsModelFrame = false;
                    this.name = "セルフ影";
                    break;
                case FrameType.Property:
                    IsModelFrame = false;
                    this.name = "表示・IK・外観";
                    break;
                default:
                    throw new ArgumentException();
            }
        }

        public override string ToString()
        {
            return $"{Type switch { FrameType.Morph => "M", FrameType.Motion => "B", _ => "-" }}: {Name}";
        }

        public string ToKey() => $"{Type.Name()}:{Name}";
    }
}
