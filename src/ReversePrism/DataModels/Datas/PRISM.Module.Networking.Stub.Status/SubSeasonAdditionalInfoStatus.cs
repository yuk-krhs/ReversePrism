using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 000 _parser                                  MessageParser`1<SubSeasonAdditionalInfoStatus> IL2CPP_TYPE_GENERICINST
    // 010 _unknownFields                           UnknownFieldSet IL2CPP_TYPE_CLASS
    // 000 MstSubSeasonIdFieldNumber                int IL2CPP_TYPE_I4
    // 018 MstSubSeasonId                           0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 MstSubSeasonTypeIdFieldNumber            int IL2CPP_TYPE_I4
    // 01C MstSubSeasonTypeId                       0001865F2AF0 ModelPrimitiveType int int int Int32
    // 000 JointTrainingCampFieldNumber             int IL2CPP_TYPE_I4
    // 020 JointTrainingCamp                        0001865D5ED0 ModelClassType SubSeasonJointTrainingCampStatus SubSeasonJointTrainingCampStatus SubSeasonJointTrainingCampStatus Pointer
    public partial class SubSeasonAdditionalInfoStatus
    {
        public int                                      MstSubSeasonId                          { get; set; }
        public int                                      MstSubSeasonTypeId                      { get; set; }
        public SubSeasonJointTrainingCampStatus?        JointTrainingCamp                       { get; set; }

        public static SubSeasonAdditionalInfoStatus? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new SubSeasonAdditionalInfoStatus();

            value.MstSubSeasonId                            = GetInt32(new IntPtr(p + 0x018)); // 0270D114A2D8 0x18 MstSubSeasonId              ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.MstSubSeasonTypeId                        = GetInt32(new IntPtr(p + 0x01C)); // 0270D114A318 0x1C MstSubSeasonTypeId          ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.JointTrainingCamp                         = GetObject<SubSeasonJointTrainingCampStatus>(new IntPtr(p + 0x020), ReversePrism.DataModels.SubSeasonJointTrainingCampStatus.FromPointer); // 0270D114A358 0x20 JointTrainingCamp           ( 0001865D5ED0 ModelClassType SubSeasonJointTrainingCampStatus SubSeasonJointTrainingCampStatus SubSeasonJointTrainingCampStatus Pointer )

            return value;
        }
    }
}
