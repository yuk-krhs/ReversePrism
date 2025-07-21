using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 Guid                                     ModelPrimitiveType string string string String
    // 030 MsgCollId                                ModelPrimitiveType string string string String
    // 038 Recipients                               ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer
    // 040 Title                                    ModelPrimitiveType string string string String
    // 048 Message                                  ModelPrimitiveType string string string String
    // 050 Urls                                     ModelClassListType List`1<Url> List`1<Url> List<Url> Pointer
    public partial class MessageParameter : DataModel
    {
        public string                                   Guid                                    { get; set; }
        public string                                   MsgCollId                               { get; set; }
        public List<string>?                            Recipients                              { get; set; }
        public string                                   Title                                   { get; set; }
        public string                                   Message                                 { get; set; }
        public List<Url>?                               Urls                                    { get; set; }

        public static MessageParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new MessageParameter() { Pointer= p0 };

            value.Guid                                      = GetString(new IntPtr(p + 0x028)); // 0x28 Guid                        ( ModelPrimitiveType string string string String )
            value.MsgCollId                                 = GetString(new IntPtr(p + 0x030)); // 0x30 MsgCollId                   ( ModelPrimitiveType string string string String )
            value.Recipients                                = GetStringList(new IntPtr(p + 0x038)); // 0x38 Recipients                  ( ModelPrimitiveListType List`1<string> List`1<string> List<string> Pointer )
            value.Title                                     = GetString(new IntPtr(p + 0x040)); // 0x40 Title                       ( ModelPrimitiveType string string string String )
            value.Message                                   = GetString(new IntPtr(p + 0x048)); // 0x48 Message                     ( ModelPrimitiveType string string string String )
            value.Urls                                      = GetObjectList<Url>(new IntPtr(p + 0x050), ReversePrism.DataModels.Url.FromPointer); // 0x50 Urls                        ( ModelClassListType List`1<Url> List`1<Url> List<Url> Pointer )

            return value;
        }
    }
}
