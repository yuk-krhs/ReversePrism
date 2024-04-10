using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 038 _returnValue                             <object> IL2CPP_TYPE_OBJECT
    // 040 Exception                                00018651E220 ModelClassType CADArgHolder CADArgHolder CADArgHolder Pointer
    // 048 Sig                                      000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer
    public partial class CADMethodReturnMessage : DataModel
    {
        public CADArgHolder?                            Exception                               { get; set; }
        public List<Type>?                              Sig                                     { get; set; }

        public static CADMethodReturnMessage? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CADMethodReturnMessage() { Pointer= p0 };

            value.Exception                                 = GetObject<CADArgHolder>(new IntPtr(p + 0x040), ReversePrism.DataModels.CADArgHolder.FromPointer); // 024666AC4BB0 0x40 Exception                   ( 00018651E220 ModelClassType CADArgHolder CADArgHolder CADArgHolder Pointer )
            value.Sig                                       = GetObjectList<Type>(new IntPtr(p + 0x048), ReversePrism.DataModels.Type.FromPointer); // 024666AC4BD0 0x48 Sig                         ( 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer )

            return value;
        }
    }
}
