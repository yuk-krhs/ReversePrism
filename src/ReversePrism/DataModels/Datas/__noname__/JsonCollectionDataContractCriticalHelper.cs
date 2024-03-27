using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 028 JsonFormatReaderDelegate                 0001867537F0 ModelClassType JsonFormatCollectionReaderDelegate JsonFormatCollectionReaderDelegate JsonFormatCollectionReaderDelegate Pointer
    // 030 JsonFormatGetOnlyReaderDelegate          0001867543D0 ModelClassType JsonFormatGetOnlyCollectionReaderDelegate JsonFormatGetOnlyCollectionReaderDelegate JsonFormatGetOnlyCollectionReaderDelegate Pointer
    // 038 JsonFormatWriterDelegate                 000186753CA0 ModelClassType JsonFormatCollectionWriterDelegate JsonFormatCollectionWriterDelegate JsonFormatCollectionWriterDelegate Pointer
    // 040 TraditionalCollectionDataContract        0001865C4B80 ModelClassType CollectionDataContract CollectionDataContract CollectionDataContract Pointer
    public partial class JsonCollectionDataContractCriticalHelper
    {
        public JsonFormatCollectionReaderDelegate?      JsonFormatReaderDelegate                { get; set; }
        public JsonFormatGetOnlyCollectionReaderDelegate? JsonFormatGetOnlyReaderDelegate         { get; set; }
        public JsonFormatCollectionWriterDelegate?      JsonFormatWriterDelegate                { get; set; }
        public CollectionDataContract?                  TraditionalCollectionDataContract       { get; set; }

        public static JsonCollectionDataContractCriticalHelper? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new JsonCollectionDataContractCriticalHelper();

            value.JsonFormatReaderDelegate                  = GetObject<JsonFormatCollectionReaderDelegate>(new IntPtr(p + 0x028), ReversePrism.DataModels.JsonFormatCollectionReaderDelegate.FromPointer); // 027004D703E8 0x28 JsonFormatReaderDelegate    ( 0001867537F0 ModelClassType JsonFormatCollectionReaderDelegate JsonFormatCollectionReaderDelegate JsonFormatCollectionReaderDelegate Pointer )
            value.JsonFormatGetOnlyReaderDelegate           = GetObject<JsonFormatGetOnlyCollectionReaderDelegate>(new IntPtr(p + 0x030), ReversePrism.DataModels.JsonFormatGetOnlyCollectionReaderDelegate.FromPointer); // 027004D70408 0x30 JsonFormatGetOnlyReaderDelegate ( 0001867543D0 ModelClassType JsonFormatGetOnlyCollectionReaderDelegate JsonFormatGetOnlyCollectionReaderDelegate JsonFormatGetOnlyCollectionReaderDelegate Pointer )
            value.JsonFormatWriterDelegate                  = GetObject<JsonFormatCollectionWriterDelegate>(new IntPtr(p + 0x038), ReversePrism.DataModels.JsonFormatCollectionWriterDelegate.FromPointer); // 027004D70428 0x38 JsonFormatWriterDelegate    ( 000186753CA0 ModelClassType JsonFormatCollectionWriterDelegate JsonFormatCollectionWriterDelegate JsonFormatCollectionWriterDelegate Pointer )
            value.TraditionalCollectionDataContract         = GetObject<CollectionDataContract>(new IntPtr(p + 0x040), ReversePrism.DataModels.CollectionDataContract.FromPointer); // 027004D70448 0x40 TraditionalCollectionDataContract ( 0001865C4B80 ModelClassType CollectionDataContract CollectionDataContract CollectionDataContract Pointer )

            return value;
        }
    }
}
