using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 090 Types                                    ModelClassListType Type[] Type[] List<Type> Pointer
    // 098 LoaderExceptions                         ModelClassListType Exception[] Exception[] List<Exception> Pointer
    public partial class ReflectionTypeLoadException : DataModel
    {
        public List<Type>?                              Types                                   { get; set; }
        public List<Exception>?                         LoaderExceptions                        { get; set; }

        public static ReflectionTypeLoadException? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ReflectionTypeLoadException() { Pointer= p0 };

            value.Types                                     = GetObjectList<Type>(new IntPtr(p + 0x090), ReversePrism.DataModels.Type.FromPointer); // 0x90 Types                       ( ModelClassListType Type[] Type[] List<Type> Pointer )
            value.LoaderExceptions                          = GetObjectList<Exception>(new IntPtr(p + 0x098), ReversePrism.DataModels.Exception.FromPointer); // 0x98 LoaderExceptions            ( ModelClassListType Exception[] Exception[] List<Exception> Pointer )

            return value;
        }
    }
}
