using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 returnValue                              <object> IL2CPP_TYPE_OBJECT
    // 018 args                                     <object>[] IL2CPP_TYPE_SZARRAY
    // 020 callContext                              <object> IL2CPP_TYPE_OBJECT
    // 028 ArgTypes                                 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer
    // 030 BArgsPrimitive                           000186594D10 ModelPrimitiveType bool bool bool Bool
    // 034 MessageEnum                              000186607C50 ModelEnumType MessageEnum MessageEnum MessageEnum Int32
    // 038 ReturnType                               000186692850 ModelClassType Type Type Type Pointer
    // 000 instanceOfVoid                           <object> IL2CPP_TYPE_OBJECT
    public partial class BinaryMethodReturn : DataModel
    {
        public List<Type>?                              ArgTypes                                { get; set; }
        public bool                                     BArgsPrimitive                          { get; set; }
        public MessageEnum                              MessageEnum                             { get; set; }
        public Type?                                    ReturnType                              { get; set; }

        public static BinaryMethodReturn? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new BinaryMethodReturn() { Pointer= p0 };

            value.ArgTypes                                  = GetObjectList<Type>(new IntPtr(p + 0x028), ReversePrism.DataModels.Type.FromPointer); // 024666CA1A40 0x28 ArgTypes                    ( 000185B82C10 ModelClassListType Type[] Type[] List<Type> Pointer )
            value.BArgsPrimitive                            = GetBool(new IntPtr(p + 0x030)); // 024666CA1A60 0x30 BArgsPrimitive              ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.MessageEnum                               = (MessageEnum)GetInt32(new IntPtr(p + 0x034)); // 024666CA1A80 0x34 MessageEnum                 ( 000186607C50 ModelEnumType MessageEnum MessageEnum MessageEnum Int32 )
            value.ReturnType                                = GetObject<Type>(new IntPtr(p + 0x038), ReversePrism.DataModels.Type.FromPointer); // 024666CA1AA0 0x38 ReturnType                  ( 000186692850 ModelClassType Type Type Type Pointer )

            return value;
        }
    }
}
