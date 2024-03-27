using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Name                                     0001866722E0 ModelPrimitiveType string string string String
    // 018 Imported                                 000186595960 ModelPrimitiveType bool bool bool Bool
    // 01C CreationPassIndex                        0001865F36C0 ModelPrimitiveType int int int Int32
    // 020 ReleasePassIndex                         0001865F36C0 ModelPrimitiveType int int int Int32
    // 028 ConsumerList                             000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    // 030 ProducerList                             000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer
    public partial class ResourceDebugData
    {
        public string                                   Name                                    { get; set; }
        public bool                                     Imported                                { get; set; }
        public int                                      CreationPassIndex                       { get; set; }
        public int                                      ReleasePassIndex                        { get; set; }
        public List<int>?                               ConsumerList                            { get; set; }
        public List<int>?                               ProducerList                            { get; set; }

        public static ResourceDebugData? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ResourceDebugData();

            value.Name                                      = GetString(new IntPtr(p + 0x010)); // 0270D907BAB0 0x10 Name                        ( 0001866722E0 ModelPrimitiveType string string string String )
            value.Imported                                  = GetBool(new IntPtr(p + 0x018)); // 0270D907BAD0 0x18 Imported                    ( 000186595960 ModelPrimitiveType bool bool bool Bool )
            value.CreationPassIndex                         = GetInt32(new IntPtr(p + 0x01C)); // 0270D907BAF0 0x1C CreationPassIndex           ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ReleasePassIndex                          = GetInt32(new IntPtr(p + 0x020)); // 0270D907BB10 0x20 ReleasePassIndex            ( 0001865F36C0 ModelPrimitiveType int int int Int32 )
            value.ConsumerList                              = GetInt32List(new IntPtr(p + 0x028)); // 0270D907BB30 0x28 ConsumerList                ( 000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )
            value.ProducerList                              = GetInt32List(new IntPtr(p + 0x030)); // 0270D907BB50 0x30 ProducerList                ( 000185CED0A8 ModelPrimitiveListType List`1<int> List`1<int> List<int> Pointer )

            return value;
        }
    }
}
