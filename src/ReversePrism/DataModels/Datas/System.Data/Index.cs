using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 Table                                    ModelClassType DataTable DataTable DataTable Pointer
    // 018 IndexFields                              ModelEnumListType IndexField[] IndexField[] List<IndexField> Pointer
    // 020 _comparison                              Comparison`1<DataRow> IL2CPP_TYPE_GENERICINST
    // 028 RecordStates                             ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32
    // 030 RowFilter                                ModelClassType WeakReference WeakReference WeakReference Pointer
    // 038 Records                                  ModelClassType IndexTree IndexTree IndexTree Pointer
    // 040 RecordCount                              ModelPrimitiveType int int int Int32
    // 044 RefCount                                 ModelPrimitiveType int int int Int32
    // 048 _listeners                               Listeners`1<DataViewListener> IL2CPP_TYPE_GENERICINST
    // 050 SuspendEvents                            ModelPrimitiveType bool bool bool Bool
    // 051 IsSharable                               ModelPrimitiveType bool bool bool Bool
    // 052 HasRemoteAggregate                       ModelPrimitiveType bool bool bool Bool
    // 000 s_objectTypeCount                        int IL2CPP_TYPE_I4
    // 054 ObjectID                                 ModelPrimitiveType int int int Int32
    public partial class Index : DataModel
    {
        public DataTable?                               Table                                   { get; set; }
        public List<IndexField>?                        IndexFields                             { get; set; }
        public DataViewRowState                         RecordStates                            { get; set; }
        public WeakReference?                           RowFilter                               { get; set; }
        public IndexTree?                               Records                                 { get; set; }
        public int                                      RecordCount                             { get; set; }
        public int                                      RefCount                                { get; set; }
        public bool                                     SuspendEvents                           { get; set; }
        public bool                                     IsSharable                              { get; set; }
        public bool                                     HasRemoteAggregate                      { get; set; }
        public int                                      ObjectID                                { get; set; }

        public static Index? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new Index() { Pointer= p0 };

            value.Table                                     = GetObject<DataTable>(new IntPtr(p + 0x010), ReversePrism.DataModels.DataTable.FromPointer); // 0x10 Table                       ( ModelClassType DataTable DataTable DataTable Pointer )
            value.IndexFields                               = GetEnumList<IndexField>(new IntPtr(p + 0x018)); // 0x18 IndexFields                 ( ModelEnumListType IndexField[] IndexField[] List<IndexField> Pointer )
            value.RecordStates                              = (DataViewRowState)GetInt32(new IntPtr(p + 0x028)); // 0x28 RecordStates                ( ModelEnumType DataViewRowState DataViewRowState DataViewRowState Int32 )
            value.RowFilter                                 = GetObject<WeakReference>(new IntPtr(p + 0x030), ReversePrism.DataModels.WeakReference.FromPointer); // 0x30 RowFilter                   ( ModelClassType WeakReference WeakReference WeakReference Pointer )
            value.Records                                   = GetObject<IndexTree>(new IntPtr(p + 0x038), ReversePrism.DataModels.IndexTree.FromPointer); // 0x38 Records                     ( ModelClassType IndexTree IndexTree IndexTree Pointer )
            value.RecordCount                               = GetInt32(new IntPtr(p + 0x040)); // 0x40 RecordCount                 ( ModelPrimitiveType int int int Int32 )
            value.RefCount                                  = GetInt32(new IntPtr(p + 0x044)); // 0x44 RefCount                    ( ModelPrimitiveType int int int Int32 )
            value.SuspendEvents                             = GetBool(new IntPtr(p + 0x050)); // 0x50 SuspendEvents               ( ModelPrimitiveType bool bool bool Bool )
            value.IsSharable                                = GetBool(new IntPtr(p + 0x051)); // 0x51 IsSharable                  ( ModelPrimitiveType bool bool bool Bool )
            value.HasRemoteAggregate                        = GetBool(new IntPtr(p + 0x052)); // 0x52 HasRemoteAggregate          ( ModelPrimitiveType bool bool bool Bool )
            value.ObjectID                                  = GetInt32(new IntPtr(p + 0x054)); // 0x54 ObjectID                    ( ModelPrimitiveType int int int Int32 )

            return value;
        }
    }
}
