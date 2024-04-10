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
    // 010 S_CallSiteOps_GetMatch                   000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 018 S_CallSiteOps_ClearMatch                 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 020 S_CallSiteOps_UpdateRules                000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 028 S_CallSiteOps_GetRules                   000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 030 S_CallSiteOps_GetRuleCache               000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 038 S_CallSiteOps_GetCachedRules             000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 040 S_CallSiteOps_AddRule                    000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 048 S_CallSiteOps_MoveRule                   000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 050 S_CallSiteOps_Bind                       000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 058 S_String_op_Equality_String_String       000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
    // 060 S_Math_Pow_Double_Double                 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer
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

            value.S_CallSiteOps_GetMatch                    = GetObject<MethodInfo>(new IntPtr(p + 0x010), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F6ABD8 0x10 S_CallSiteOps_GetMatch      ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_ClearMatch                  = GetObject<MethodInfo>(new IntPtr(p + 0x018), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F6ABF8 0x18 S_CallSiteOps_ClearMatch    ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_UpdateRules                 = GetObject<MethodInfo>(new IntPtr(p + 0x020), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F6AC18 0x20 S_CallSiteOps_UpdateRules   ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_GetRules                    = GetObject<MethodInfo>(new IntPtr(p + 0x028), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F6AC38 0x28 S_CallSiteOps_GetRules      ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_GetRuleCache                = GetObject<MethodInfo>(new IntPtr(p + 0x030), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F6AC58 0x30 S_CallSiteOps_GetRuleCache  ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_GetCachedRules              = GetObject<MethodInfo>(new IntPtr(p + 0x038), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F6AC78 0x38 S_CallSiteOps_GetCachedRules ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_AddRule                     = GetObject<MethodInfo>(new IntPtr(p + 0x040), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F6AC98 0x40 S_CallSiteOps_AddRule       ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_MoveRule                    = GetObject<MethodInfo>(new IntPtr(p + 0x048), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F6ACB8 0x48 S_CallSiteOps_MoveRule      ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_CallSiteOps_Bind                        = GetObject<MethodInfo>(new IntPtr(p + 0x050), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F6ACD8 0x50 S_CallSiteOps_Bind          ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_String_op_Equality_String_String        = GetObject<MethodInfo>(new IntPtr(p + 0x058), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F6ACF8 0x58 S_String_op_Equality_String_String ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )
            value.S_Math_Pow_Double_Double                  = GetObject<MethodInfo>(new IntPtr(p + 0x060), ReversePrism.DataModels.MethodInfo.FromPointer); // 024669F6AD18 0x60 S_Math_Pow_Double_Double    ( 000186613AB0 ModelClassType MethodInfo MethodInfo MethodInfo Pointer )

            return value;
        }
    }
}
