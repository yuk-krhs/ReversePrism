using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_object                                 <object> IL2CPP_TYPE_OBJECT
    // 018 M_id                                     0001865F79C0 ModelPrimitiveType long long long Int64
    // 020 M_missingElementsRemaining               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 024 M_missingDecendents                      0001865F2AF0 ModelPrimitiveType int int int Int32
    // 028 M_serInfo                                000186663980 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
    // 030 M_surrogate                              000186636BB0 ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer
    // 038 M_missingElements                        0001865A2C70 ModelClassType FixupHolderList FixupHolderList FixupHolderList Pointer
    // 040 M_dependentObjects                       0001865BEE20 ModelClassType LongList LongList LongList Pointer
    // 048 M_next                                   0001866394A0 ModelClassType ObjectHolder ObjectHolder ObjectHolder Pointer
    // 050 M_flags                                  0001865F2F90 ModelPrimitiveType int int int Int32
    // 054 M_markForFixupWhenAvailable              000186594D10 ModelPrimitiveType bool bool bool Bool
    // 058 M_valueFixup                             000186771360 ModelClassType ValueTypeFixupInfo ValueTypeFixupInfo ValueTypeFixupInfo Pointer
    // 060 M_typeLoad                               0001866D98B0 ModelClassType TypeLoadExceptionHolder TypeLoadExceptionHolder TypeLoadExceptionHolder Pointer
    // 068 M_reachable                              000186594D10 ModelPrimitiveType bool bool bool Bool
    public partial class ObjectHolder
    {
        public long                                     M_id                                    { get; set; }
        public int                                      M_missingElementsRemaining              { get; set; }
        public int                                      M_missingDecendents                     { get; set; }
        public SerializationInfo?                       M_serInfo                               { get; set; }
        public ISerializationSurrogate?                 M_surrogate                             { get; set; }
        public FixupHolderList?                         M_missingElements                       { get; set; }
        public LongList?                                M_dependentObjects                      { get; set; }
        public ObjectHolder?                            M_next                                  { get; set; }
        public int                                      M_flags                                 { get; set; }
        public bool                                     M_markForFixupWhenAvailable             { get; set; }
        public ValueTypeFixupInfo?                      M_valueFixup                            { get; set; }
        public TypeLoadExceptionHolder?                 M_typeLoad                              { get; set; }
        public bool                                     M_reachable                             { get; set; }

        public static ObjectHolder? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new ObjectHolder();

            value.M_id                                      = GetInt64(new IntPtr(p + 0x018)); // 0270D6C1E5B8 0x18 M_id                        ( 0001865F79C0 ModelPrimitiveType long long long Int64 )
            value.M_missingElementsRemaining                = GetInt32(new IntPtr(p + 0x020)); // 0270D6C1E5D8 0x20 M_missingElementsRemaining  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_missingDecendents                       = GetInt32(new IntPtr(p + 0x024)); // 0270D6C1E5F8 0x24 M_missingDecendents         ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.M_serInfo                                 = GetObject<SerializationInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.SerializationInfo.FromPointer); // 0270D6C1E618 0x28 M_serInfo                   ( 000186663980 ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )
            value.M_surrogate                               = GetObject<ISerializationSurrogate>(new IntPtr(p + 0x030), ReversePrism.DataModels.ISerializationSurrogate.FromPointer); // 0270D6C1E638 0x30 M_surrogate                 ( 000186636BB0 ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer )
            value.M_missingElements                         = GetObject<FixupHolderList>(new IntPtr(p + 0x038), ReversePrism.DataModels.FixupHolderList.FromPointer); // 0270D6C1E658 0x38 M_missingElements           ( 0001865A2C70 ModelClassType FixupHolderList FixupHolderList FixupHolderList Pointer )
            value.M_dependentObjects                        = GetObject<LongList>(new IntPtr(p + 0x040), ReversePrism.DataModels.LongList.FromPointer); // 0270D6C1E678 0x40 M_dependentObjects          ( 0001865BEE20 ModelClassType LongList LongList LongList Pointer )
            value.M_next                                    = GetObject<ObjectHolder>(new IntPtr(p + 0x048), ReversePrism.DataModels.ObjectHolder.FromPointer); // 0270D6C1E698 0x48 M_next                      ( 0001866394A0 ModelClassType ObjectHolder ObjectHolder ObjectHolder Pointer )
            value.M_flags                                   = GetInt32(new IntPtr(p + 0x050)); // 0270D6C1E6B8 0x50 M_flags                     ( 0001865F2F90 ModelPrimitiveType int int int Int32 )
            value.M_markForFixupWhenAvailable               = GetBool(new IntPtr(p + 0x054)); // 0270D6C1E6D8 0x54 M_markForFixupWhenAvailable ( 000186594D10 ModelPrimitiveType bool bool bool Bool )
            value.M_valueFixup                              = GetObject<ValueTypeFixupInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.ValueTypeFixupInfo.FromPointer); // 0270D6C1E6F8 0x58 M_valueFixup                ( 000186771360 ModelClassType ValueTypeFixupInfo ValueTypeFixupInfo ValueTypeFixupInfo Pointer )
            value.M_typeLoad                                = GetObject<TypeLoadExceptionHolder>(new IntPtr(p + 0x060), ReversePrism.DataModels.TypeLoadExceptionHolder.FromPointer); // 0270D6C1E718 0x60 M_typeLoad                  ( 0001866D98B0 ModelClassType TypeLoadExceptionHolder TypeLoadExceptionHolder TypeLoadExceptionHolder Pointer )
            value.M_reachable                               = GetBool(new IntPtr(p + 0x068)); // 0270D6C1E738 0x68 M_reachable                 ( 000186594D10 ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
