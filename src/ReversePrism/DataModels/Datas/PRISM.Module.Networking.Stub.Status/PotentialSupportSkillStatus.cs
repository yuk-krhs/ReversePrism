using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<PotentialSupportSkillStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstPotentialSupportSkillIdFieldNumber    int IL2CPP_TYPE_I4
    // 018 MstPotentialSupportSkillId               0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 ProduceEntrustFieldNumber                int IL2CPP_TYPE_I4
    // 020 ProduceEntrust                           00018653E020 ModelClassType ProduceEntrustStatus ProduceEntrustStatus ProduceEntrustStatus Pointer
    public partial class PotentialSupportSkillStatus
    {
        public int                                      MstPotentialSupportSkillId              { get; set; }
        public ProduceEntrustStatus?                    ProduceEntrust                          { get; set; }

        public static PotentialSupportSkillStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new PotentialSupportSkillStatus();

            value.MstPotentialSupportSkillId                = GetInt32(new IntPtr(p + 0x018)); // 0270D1423470 0x18 MstPotentialSupportSkillId  ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.ProduceEntrust                            = GetObject<ProduceEntrustStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.ProduceEntrustStatus.FromPointer); // 0270D14234B0 0x20 ProduceEntrust              ( 00018653E020 ModelClassType ProduceEntrustStatus ProduceEntrustStatus ProduceEntrustStatus Pointer )

            return value;
        }
    }
}
