using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 ValidIndexMaskOffFlags                   CompareOptions IL2CPP_TYPE_VALUETYPE
    // 000 ValidCompareMaskOffFlags                 CompareOptions IL2CPP_TYPE_VALUETYPE
    // 000 ValidHashCodeOfStringMaskOffFlags        CompareOptions IL2CPP_TYPE_VALUETYPE
    // 000 ValidSortkeyCtorMaskOffFlags             CompareOptions IL2CPP_TYPE_VALUETYPE
    // 000 Invariant                                CompareInfo IL2CPP_TYPE_CLASS
    // 010 M_name                                   ModelPrimitiveType string string string String
    // 018 SortName                                 ModelPrimitiveType string string string String
    // 020 M_SortVersion                            ModelClassType SortVersion SortVersion SortVersion Pointer
    // 028 Culture                                  ModelPrimitiveType int int int Int32
    // 030 Collator                                 ModelClassType ISimpleCollator ISimpleCollator ISimpleCollator Pointer
    // 008 collators                                Dictionary`2<string, ISimpleCollator> IL2CPP_TYPE_GENERICINST
    // 010 ManagedCollation                         ModelPrimitiveType bool bool bool Bool
    // 011 ManagedCollationChecked                  ModelPrimitiveType bool bool bool Bool
    public partial class CompareInfo : DataModel
    {
        public string                                   M_name                                  { get; set; }
        public string                                   SortName                                { get; set; }
        public SortVersion?                             M_SortVersion                           { get; set; }
        public int                                      Culture                                 { get; set; }
        public ISimpleCollator?                         Collator                                { get; set; }
        public bool                                     ManagedCollation                        { get; set; }
        public bool                                     ManagedCollationChecked                 { get; set; }

        public static CompareInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CompareInfo() { Pointer= p0 };

            value.M_name                                    = GetString(new IntPtr(p + 0x010)); // 0x10 M_name                      ( ModelPrimitiveType string string string String )
            value.SortName                                  = GetString(new IntPtr(p + 0x018)); // 0x18 SortName                    ( ModelPrimitiveType string string string String )
            value.M_SortVersion                             = GetObject<SortVersion>(new IntPtr(p + 0x020), ReversePrism.DataModels.SortVersion.FromPointer); // 0x20 M_SortVersion               ( ModelClassType SortVersion SortVersion SortVersion Pointer )
            value.Culture                                   = GetInt32(new IntPtr(p + 0x028)); // 0x28 Culture                     ( ModelPrimitiveType int int int Int32 )
            value.Collator                                  = GetObject<ISimpleCollator>(new IntPtr(p + 0x030), ReversePrism.DataModels.ISimpleCollator.FromPointer); // 0x30 Collator                    ( ModelClassType ISimpleCollator ISimpleCollator ISimpleCollator Pointer )
            value.ManagedCollation                          = GetBool(new IntPtr(p + 0x010)); // 0x10 ManagedCollation            ( ModelPrimitiveType bool bool bool Bool )
            value.ManagedCollationChecked                   = GetBool(new IntPtr(p + 0x011)); // 0x11 ManagedCollationChecked     ( ModelPrimitiveType bool bool bool Bool )

            return value;
        }
    }
}
