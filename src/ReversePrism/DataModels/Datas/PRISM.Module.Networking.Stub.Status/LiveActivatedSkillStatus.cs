using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<LiveActivatedSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 FesIdolIdFieldNumber                     int IL2CPP_TYPE_I4
    // 018 FesIdolId                                000186671910 ModelPrimitiveType string string string String
    // 000 MstPotentialLevelSkillIdFieldNumber      int IL2CPP_TYPE_I4
    // 020 MstPotentialLevelSkillId                 0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 CountFieldNumber                         int IL2CPP_TYPE_I4
    // 024 Count                                    0001865F2AF0 ModelPrimitiveType int int int Int32
    public partial class LiveActivatedSkillStatus : DataModel
    {
        public string                                   FesIdolId                               { get; set; }
        public int                                      MstPotentialLevelSkillId                { get; set; }
        public int                                      Count                                   { get; set; }

        public static LiveActivatedSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new LiveActivatedSkillStatus() { Pointer= p0 };

            value.FesIdolId                                 = GetString(new IntPtr(p + 0x018)); // 0246612C9CC0 0x18 FesIdolId                   ( 000186671910 ModelPrimitiveType string string string String )
            value.MstPotentialLevelSkillId                  = GetInt32(new IntPtr(p + 0x020)); // 0246612C9D00 0x20 MstPotentialLevelSkillId    ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Count                                     = GetInt32(new IntPtr(p + 0x024)); // 0246612C9D40 0x24 Count                       ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
