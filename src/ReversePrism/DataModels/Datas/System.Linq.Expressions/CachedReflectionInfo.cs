using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 s_CallSiteOps_SetNotMatched              MethodInfo IL2CPP_TYPE_CLASS
    // 008 s_CallSiteOps_CreateMatchmaker           MethodInfo IL2CPP_TYPE_CLASS
    // 010 S_CallSiteOps_GetMatch                   ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 018 S_CallSiteOps_ClearMatch                 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 020 S_CallSiteOps_UpdateRules                ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 028 S_CallSiteOps_GetRules                   ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 030 S_CallSiteOps_GetRuleCache               ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 038 S_CallSiteOps_GetCachedRules             ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 040 S_CallSiteOps_AddRule                    ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 048 S_CallSiteOps_MoveRule                   ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 050 S_CallSiteOps_Bind                       ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 058 S_String_op_Equality_String_String       ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 060 S_Math_Pow_Double_Double                 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    public partial class CachedReflectionInfo : DataModel
    {
        public MethodInfo?                              S_CallSiteOps_GetMatch                  { get; set; }
        public MethodInfo?                              S_CallSiteOps_ClearMatch                { get; set; }
        public MethodInfo?                              S_CallSiteOps_UpdateRules               { get; set; }
        public MethodInfo?                              S_CallSiteOps_GetRules                  { get; set; }
        public MethodInfo?                              S_CallSiteOps_GetRuleCache              { get; set; }
        public MethodInfo?                              S_CallSiteOps_GetCachedRules            { get; set; }
        public MethodInfo?                              S_CallSiteOps_AddRule                   { get; set; }
        public MethodInfo?                              S_CallSiteOps_MoveRule                  { get; set; }
        public MethodInfo?                              S_CallSiteOps_Bind                      { get; set; }
        public MethodInfo?                              S_String_op_Equality_String_String      { get; set; }
        public MethodInfo?                              S_Math_Pow_Double_Double                { get; set; }

        public static CachedReflectionInfo? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new CachedReflectionInfo() { Pointer= p0 };

            value.S_CallSiteOps_GetMatch                    = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x10 S_CallSiteOps_GetMatch      ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_ClearMatch                  = GetObject<MethodInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x18 S_CallSiteOps_ClearMatch    ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_UpdateRules                 = GetObject<MethodInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x20 S_CallSiteOps_UpdateRules   ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_GetRules                    = GetObject<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x28 S_CallSiteOps_GetRules      ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_GetRuleCache                = GetObject<MethodInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x30 S_CallSiteOps_GetRuleCache  ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_GetCachedRules              = GetObject<MethodInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x38 S_CallSiteOps_GetCachedRules ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_AddRule                     = GetObject<MethodInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x40 S_CallSiteOps_AddRule       ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_MoveRule                    = GetObject<MethodInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x48 S_CallSiteOps_MoveRule      ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_Bind                        = GetObject<MethodInfo>(new IntPtr(p + 0x050), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x50 S_CallSiteOps_Bind          ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_String_op_Equality_String_String        = GetObject<MethodInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x58 S_String_op_Equality_String_String ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_Math_Pow_Double_Double                  = GetObject<MethodInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.MethodInfo.FromPointer); // 0x60 S_Math_Pow_Double_Double    ( ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
