using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Nodes                                    000185B89CC0 ModelClassListType IThreadPoolWorkItem[] IThreadPoolWorkItem[] List<IThreadPoolWorkItem> Pointer
    // 018 Indexes                                  0001865F2AF0 ModelPrimitiveType int int int Int32
    // 020 Next                                     0001865FFB60 ModelClassType QueueSegment QueueSegment QueueSegment Pointer
    public partial class QueueSegment : DataModel
    {
        public List<IThreadPoolWorkItem>?               Nodes                                   { get; set; }
        public int                                      Indexes                                 { get; set; }
        public QueueSegment?                            Next                                    { get; set; }

        public static QueueSegment? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new QueueSegment() { Pointer= p0 };

            value.Nodes                                     = GetObjectList<IThreadPoolWorkItem>(new IntPtr(p + 0x010), ReversePrism.DataModels.IThreadPoolWorkItem.FromPointer); // 0245A3B001A8 0x10 Nodes                       ( 000185B89CC0 ModelClassListType IThreadPoolWorkItem[] IThreadPoolWorkItem[] List<IThreadPoolWorkItem> Pointer )
            value.Indexes                                   = GetInt32(new IntPtr(p + 0x018)); // 0245A3B001C8 0x18 Indexes                     ( 0001865F2AF0 ModelPrimitiveType int int int Int32 )
            value.Next                                      = GetObject<QueueSegment>(new IntPtr(p + 0x020), ReversePrism.DataModels.QueueSegment.FromPointer); // 0245A3B001E8 0x20 Next                        ( 0001865FFB60 ModelClassType QueueSegment QueueSegment QueueSegment Pointer )

            return value;
        }
    }
}
