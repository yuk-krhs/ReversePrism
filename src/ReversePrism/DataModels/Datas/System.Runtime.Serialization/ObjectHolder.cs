using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 m_object                                 <object> IL2CPP_TYPE_OBJECT
    // 018 M_id                                     ModelPrimitiveType long long long Int64
    // 020 M_missingElementsRemaining               ModelPrimitiveType int int int Int32
    // 024 M_missingDecendents                      ModelPrimitiveType int int int Int32
    // 028 M_serInfo                                ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer
    // 030 M_surrogate                              ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer
    // 038 M_missingElements                        ModelClassType FixupHolderList FixupHolderList FixupHolderList Pointer
    // 040 M_dependentObjects                       ModelClassType LongList LongList LongList Pointer
    // 048 M_next                                   ModelClassType ObjectHolder ObjectHolder ObjectHolder Pointer
    // 050 M_flags                                  ModelPrimitiveType int int int Int32
    // 054 M_markForFixupWhenAvailable              ModelPrimitiveType bool bool bool Bool
    // 058 M_valueFixup                             ModelClassType ValueTypeFixupInfo ValueTypeFixupInfo ValueTypeFixupInfo Pointer
    // 060 M_typeLoad                               ModelClassType TypeLoadExceptionHolder TypeLoadExceptionHolder TypeLoadExceptionHolder Pointer
    // 068 M_reachable                              ModelPrimitiveType bool bool bool Bool
    public partial class ObjectHolder : DataModel
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
            var value   = new ObjectHolder() { Pointer= p0 };

            value.M_id                                      = GetInt64(new IntPtr(p + 0x018)); // 0x18 M_id                        ( ModelPrimitiveType long long long Int64 )
            value.M_missingElementsRemaining                = GetInt32(new IntPtr(p + 0x020)); // 0x20 M_missingElementsRemaining  ( ModelPrimitiveType int int int Int32 )
            value.M_missingDecendents                       = GetInt32(new IntPtr(p + 0x024)); // 0x24 M_missingDecendents         ( ModelPrimitiveType int int int Int32 )
            value.M_serInfo                                 = GetObject<SerializationInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.SerializationInfo.FromPointer); // 0x28 M_serInfo                   ( ModelClassType SerializationInfo SerializationInfo SerializationInfo Pointer )
            value.M_surrogate                               = GetObject<ISerializationSurrogate>(new IntPtr(p + 0x030), ReversePrism.DataModels.ISerializationSurrogate.FromPointer); // 0x30 M_surrogate                 ( ModelClassType ISerializationSurrogate ISerializationSurrogate ISerializationSurrogate Pointer )
            value.M_missingElements                         = GetObject<FixupHolderList>(new IntPtr(p + 0x038), ReversePrism.DataModels.FixupHolderList.FromPointer); // 0x38 M_missingElements           ( ModelClassType FixupHolderList FixupHolderList FixupHolderList Pointer )
            value.M_dependentObjects                        = GetObject<LongList>(new IntPtr(p + 0x040), ReversePrism.DataModels.LongList.FromPointer); // 0x40 M_dependentObjects          ( ModelClassType LongList LongList LongList Pointer )
            value.M_next                                    = GetObject<ObjectHolder>(new IntPtr(p + 0x048), ReversePrism.DataModels.ObjectHolder.FromPointer); // 0x48 M_next                      ( ModelClassType ObjectHolder ObjectHolder ObjectHolder Pointer )
            value.M_flags                                   = GetInt32(new IntPtr(p + 0x050)); // 0x50 M_flags                     ( ModelPrimitiveType int int int Int32 )
            value.M_markForFixupWhenAvailable               = GetBool(new IntPtr(p + 0x054)); // 0x54 M_markForFixupWhenAvailable ( ModelPrimitiveType bool bool bool Bool )
            value.M_valueFixup                              = GetObject<ValueTypeFixupInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.ValueTypeFixupInfo.FromPointer); // 0x58 M_valueFixup                ( ModelClassType ValueTypeFixupInfo ValueTypeFixupInfo ValueTypeFixupInfo Pointer )
            value.M_typeLoad                                = GetObject<TypeLoadExceptionHolder>(new IntPtr(p + 0x060), ReversePrism.DataModels.TypeLoadExceptionHolder.FromPointer); // 0x60 M_typeLoad                  ( ModelClassType TypeLoadExceptionHolder TypeLoadExceptionHolder TypeLoadExceptionHolder Pointer )
            value.M_reachable                               = GetBool(new IntPtr(p + 0x068)); // 0x68 M_reachable                 ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
