using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Model                                    0001866084F0 ModelClassType GashaModel GashaModel GashaModel Pointer
    // 018 ResourceId                               000186672F10 ModelPrimitiveType string string string String
    // 020 CostumePopupCall                         0001865965D0 ModelPrimitiveType bool bool bool Bool
    public partial class GashaParameter : DataModel
    {
        public GashaModel?                              Model                                   { get; set; }
        public string                                   ResourceId                              { get; set; }
        public bool                                     CostumePopupCall                        { get; set; }

        public static GashaParameter? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new GashaParameter() { Pointer= p0 };

            value.Model                                     = GetObject<GashaModel>(new IntPtr(p + 0x010), ReversePrism.DataModels.GashaModel.FromPointer); // 0246653C70F0 0x10 Model                       ( 0001866084F0 ModelClassType GashaModel GashaModel GashaModel Pointer )
            value.ResourceId                                = GetString(new IntPtr(p + 0x018)); // 0246653C7110 0x18 ResourceId                  ( 000186672F10 ModelPrimitiveType string string string String )
            value.CostumePopupCall                          = GetBool(new IntPtr(p + 0x020)); // 0246653C7130 0x20 CostumePopupCall            ( 0001865965D0 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
