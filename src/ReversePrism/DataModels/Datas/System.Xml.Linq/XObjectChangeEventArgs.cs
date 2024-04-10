using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 ObjectChange                             00018657CA00 ModelEnumType XObjectChange XObjectChange XObjectChange Int32
    // 000 Add                                      XObjectChangeEventArgs IL2CPP_TYPE_CLASS
    // 008 Remove                                   XObjectChangeEventArgs IL2CPP_TYPE_CLASS
    // 010 Name                                     00018657D3D0 ModelClassType XObjectChangeEventArgs XObjectChangeEventArgs XObjectChangeEventArgs Pointer
    // 018 Value                                    00018657D3D0 ModelClassType XObjectChangeEventArgs XObjectChangeEventArgs XObjectChangeEventArgs Pointer
    public partial class XObjectChangeEventArgs : DataModel
    {
        public XObjectChange                            ObjectChange                            { get; set; }
        public XObjectChangeEventArgs?                  Name                                    { get; set; }
        public XObjectChangeEventArgs?                  Value                                   { get; set; }

        public static XObjectChangeEventArgs? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new XObjectChangeEventArgs() { Pointer= p0 };

            value.ObjectChange                              = (XObjectChange)GetInt32(new IntPtr(p + 0x010)); // 02466BCB2028 0x10 ObjectChange                ( 00018657CA00 ModelEnumType XObjectChange XObjectChange XObjectChange Int32 )
            value.Name                                      = GetObject<XObjectChangeEventArgs>(new IntPtr(p + 0x010), ReversePrism.DataModels.XObjectChangeEventArgs.FromPointer); // 02466BCB2088 0x10 Name                        ( 00018657D3D0 ModelClassType XObjectChangeEventArgs XObjectChangeEventArgs XObjectChangeEventArgs Pointer )
            value.Value                                     = GetObject<XObjectChangeEventArgs>(new IntPtr(p + 0x018), ReversePrism.DataModels.XObjectChangeEventArgs.FromPointer); // 02466BCB20A8 0x18 Value                       ( 00018657D3D0 ModelClassType XObjectChangeEventArgs XObjectChangeEventArgs XObjectChangeEventArgs Pointer )

            return value;
        }
    }
}
