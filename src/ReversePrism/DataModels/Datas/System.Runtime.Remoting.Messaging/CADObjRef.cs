using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Objref                                   0001866C5710 ModelClassType ObjRef ObjRef ObjRef Pointer
    // 018 SourceDomain                             0001865F2F90 ModelPrimitiveType int int int Int32
    // 020 TypeInfo                                 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer
    public partial class CADObjRef : DataModel
    {
        public ObjRef?                                  Objref                                  { get; set; }
        public int                                      SourceDomain                            { get; set; }
        public List<sbyte>?                             TypeInfo                                { get; set; }

        public static CADObjRef? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CADObjRef() { Pointer= p0 };

            value.Objref                                    = GetObject<ObjRef>(new IntPtr(p + 0x010), ReversePrism.DataModels.ObjRef.FromPointer); // 024666C60B80 0x10 Objref                      ( 0001866C5710 ModelClassType ObjRef ObjRef ObjRef Pointer )
            value.SourceDomain                              = GetInt32(new IntPtr(p + 0x018)); // 024666C60BA0 0x18 SourceDomain                ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.TypeInfo                                  = GetSByteList(new IntPtr(p + 0x020)); // 024666C60BC0 0x20 TypeInfo                    ( 000185B79950 ModelPrimitiveListType sbyte[] sbyte[] List<sbyte> Pointer )

            return value;
        }
    }
}
