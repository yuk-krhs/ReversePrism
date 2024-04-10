using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversePrism.DataModels
{
    using static ModelMarshaler;

    // 010 UNITYTLS_INVALID_HANDLE                  00018669C740 ModelPrimitiveType ulong ulong ulong UInt64
    // 018 UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT    0001866AF210 ModelEnumType unitytls_tlsctx_protocolrange unitytls_tlsctx_protocolrange unitytls_tlsctx_protocolrange Int32
    // 020 Unitytls_errorstate_create               000186597170 ModelClassType unitytls_errorstate_create_t unitytls_errorstate_create_t unitytls_errorstate_create_t Pointer
    // 028 Unitytls_errorstate_raise_error          000186597660 ModelClassType unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error_t Pointer
    // 030 Unitytls_key_get_ref                     000186598020 ModelClassType unitytls_key_get_ref_t unitytls_key_get_ref_t unitytls_key_get_ref_t Pointer
    // 038 Unitytls_key_parse_der                   000186598500 ModelClassType unitytls_key_parse_der_t unitytls_key_parse_der_t unitytls_key_parse_der_t Pointer
    // 040 Unitytls_key_parse_pem                   0001865989F0 ModelClassType unitytls_key_parse_pem_t unitytls_key_parse_pem_t unitytls_key_parse_pem_t Pointer
    // 048 Unitytls_key_free                        000186597B60 ModelClassType unitytls_key_free_t unitytls_key_free_t unitytls_key_free_t Pointer
    // 050 Unitytls_x509_export_der                 00018659D840 ModelClassType unitytls_x509_export_der_t unitytls_x509_export_der_t unitytls_x509_export_der_t Pointer
    // 058 Unitytls_x509list_get_ref                00018659F120 ModelClassType unitytls_x509list_get_ref_t unitytls_x509list_get_ref_t unitytls_x509list_get_ref_t Pointer
    // 060 Unitytls_x509list_get_x509               00018659F590 ModelClassType unitytls_x509list_get_x509_t unitytls_x509list_get_x509_t unitytls_x509list_get_x509_t Pointer
    // 068 Unitytls_x509list_create                 00018659E720 ModelClassType unitytls_x509list_create_t unitytls_x509list_create_t unitytls_x509list_create_t Pointer
    // 070 Unitytls_x509list_append                 00018659E220 ModelClassType unitytls_x509list_append_t unitytls_x509list_append_t unitytls_x509list_append_t Pointer
    // 078 Unitytls_x509list_append_der             00018659DD20 ModelClassType unitytls_x509list_append_der_t unitytls_x509list_append_der_t unitytls_x509list_append_der_t Pointer
    // 080 Unitytls_x509list_append_pem             00018659DD20 ModelClassType unitytls_x509list_append_der_t unitytls_x509list_append_der_t unitytls_x509list_append_der_t Pointer
    // 088 Unitytls_x509list_free                   00018659EC20 ModelClassType unitytls_x509list_free_t unitytls_x509list_free_t unitytls_x509list_free_t Pointer
    // 090 Unitytls_x509verify_default_ca           00018659FAB0 ModelClassType unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca_t Pointer
    // 098 Unitytls_x509verify_explicit_ca          00018659FF90 ModelClassType unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca_t Pointer
    // 0A0 Unitytls_tlsctx_create_server            0001865998C0 ModelClassType unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server_t Pointer
    // 0A8 Unitytls_tlsctx_create_client            0001865993E0 ModelClassType unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client_t Pointer
    // 0B0 Unitytls_tlsctx_server_require_client_authentication 00018659BAE0 ModelClassType unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication_t Pointer
    // 0B8 Unitytls_tlsctx_set_certificate_callback 00018659BFD0 ModelClassType unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback_t Pointer
    // 0C0 Unitytls_tlsctx_set_trace_callback       00018659C940 ModelClassType unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback_t Pointer
    // 0C8 Unitytls_tlsctx_set_x509verify_callback  00018659CE60 ModelClassType unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback_t Pointer
    // 0D0 Unitytls_tlsctx_set_supported_ciphersuites 00018659C4C0 ModelClassType unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites_t Pointer
    // 0D8 Unitytls_tlsctx_get_ciphersuite          00018659A2A0 ModelClassType unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite_t Pointer
    // 0E0 Unitytls_tlsctx_get_protocol             00018659A7A0 ModelClassType unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol_t Pointer
    // 0E8 Unitytls_tlsctx_process_handshake        00018659B140 ModelClassType unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake_t Pointer
    // 0F0 Unitytls_tlsctx_read                     00018659B620 ModelClassType unitytls_tlsctx_read_t unitytls_tlsctx_read_t unitytls_tlsctx_read_t Pointer
    // 0F8 Unitytls_tlsctx_write                    00018659D340 ModelClassType unitytls_tlsctx_write_t unitytls_tlsctx_write_t unitytls_tlsctx_write_t Pointer
    // 100 Unitytls_tlsctx_notify_close             00018659ACA0 ModelClassType unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close_t Pointer
    // 108 Unitytls_tlsctx_free                     000186599DA0 ModelClassType unitytls_tlsctx_free_t unitytls_tlsctx_free_t unitytls_tlsctx_free_t Pointer
    // 110 Unitytls_random_generate_bytes           000186598EC0 ModelClassType unitytls_random_generate_bytes_t unitytls_random_generate_bytes_t unitytls_random_generate_bytes_t Pointer
    public partial class unitytls_interface_struct : DataModel
    {
        public ulong                                    UNITYTLS_INVALID_HANDLE                 { get; set; }
        public unitytls_tlsctx_protocolrange            UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT   { get; set; }
        public unitytls_errorstate_create_t?            Unitytls_errorstate_create              { get; set; }
        public unitytls_errorstate_raise_error_t?       Unitytls_errorstate_raise_error         { get; set; }
        public unitytls_key_get_ref_t?                  Unitytls_key_get_ref                    { get; set; }
        public unitytls_key_parse_der_t?                Unitytls_key_parse_der                  { get; set; }
        public unitytls_key_parse_pem_t?                Unitytls_key_parse_pem                  { get; set; }
        public unitytls_key_free_t?                     Unitytls_key_free                       { get; set; }
        public unitytls_x509_export_der_t?              Unitytls_x509_export_der                { get; set; }
        public unitytls_x509list_get_ref_t?             Unitytls_x509list_get_ref               { get; set; }
        public unitytls_x509list_get_x509_t?            Unitytls_x509list_get_x509              { get; set; }
        public unitytls_x509list_create_t?              Unitytls_x509list_create                { get; set; }
        public unitytls_x509list_append_t?              Unitytls_x509list_append                { get; set; }
        public unitytls_x509list_append_der_t?          Unitytls_x509list_append_der            { get; set; }
        public unitytls_x509list_append_der_t?          Unitytls_x509list_append_pem            { get; set; }
        public unitytls_x509list_free_t?                Unitytls_x509list_free                  { get; set; }
        public unitytls_x509verify_default_ca_t?        Unitytls_x509verify_default_ca          { get; set; }
        public unitytls_x509verify_explicit_ca_t?       Unitytls_x509verify_explicit_ca         { get; set; }
        public unitytls_tlsctx_create_server_t?         Unitytls_tlsctx_create_server           { get; set; }
        public unitytls_tlsctx_create_client_t?         Unitytls_tlsctx_create_client           { get; set; }
        public unitytls_tlsctx_server_require_client_authentication_t? Unitytls_tlsctx_server_require_client_authentication { get; set; }
        public unitytls_tlsctx_set_certificate_callback_t? Unitytls_tlsctx_set_certificate_callback { get; set; }
        public unitytls_tlsctx_set_trace_callback_t?    Unitytls_tlsctx_set_trace_callback      { get; set; }
        public unitytls_tlsctx_set_x509verify_callback_t? Unitytls_tlsctx_set_x509verify_callback { get; set; }
        public unitytls_tlsctx_set_supported_ciphersuites_t? Unitytls_tlsctx_set_supported_ciphersuites { get; set; }
        public unitytls_tlsctx_get_ciphersuite_t?       Unitytls_tlsctx_get_ciphersuite         { get; set; }
        public unitytls_tlsctx_get_protocol_t?          Unitytls_tlsctx_get_protocol            { get; set; }
        public unitytls_tlsctx_process_handshake_t?     Unitytls_tlsctx_process_handshake       { get; set; }
        public unitytls_tlsctx_read_t?                  Unitytls_tlsctx_read                    { get; set; }
        public unitytls_tlsctx_write_t?                 Unitytls_tlsctx_write                   { get; set; }
        public unitytls_tlsctx_notify_close_t?          Unitytls_tlsctx_notify_close            { get; set; }
        public unitytls_tlsctx_free_t?                  Unitytls_tlsctx_free                    { get; set; }
        public unitytls_random_generate_bytes_t?        Unitytls_random_generate_bytes          { get; set; }

        public static unitytls_interface_struct? FromPointer(IntPtr p0)
        {
            if(p0 == IntPtr.Zero)
                return null;

            var p       = p0.ToInt64();
            var value   = new unitytls_interface_struct() { Pointer= p0 };

            value.UNITYTLS_INVALID_HANDLE                   = GetUInt64(new IntPtr(p + 0x010)); // 024667954480 0x10 UNITYTLS_INVALID_HANDLE     ( 00018669C740 ModelPrimitiveType ulong ulong ulong UInt64 )
            value.UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT     = (unitytls_tlsctx_protocolrange)GetInt32(new IntPtr(p + 0x018)); // 0246679544A0 0x18 UNITYTLS_TLSCTX_PROTOCOLRANGE_DEFAULT ( 0001866AF210 ModelEnumType unitytls_tlsctx_protocolrange unitytls_tlsctx_protocolrange unitytls_tlsctx_protocolrange Int32 )
            value.Unitytls_errorstate_create                = GetObject<unitytls_errorstate_create_t>(new IntPtr(p + 0x020), ReversePrism.DataModels.unitytls_errorstate_create_t.FromPointer); // 0246679544C0 0x20 Unitytls_errorstate_create  ( 000186597170 ModelClassType unitytls_errorstate_create_t unitytls_errorstate_create_t unitytls_errorstate_create_t Pointer )
            value.Unitytls_errorstate_raise_error           = GetObject<unitytls_errorstate_raise_error_t>(new IntPtr(p + 0x028), ReversePrism.DataModels.unitytls_errorstate_raise_error_t.FromPointer); // 0246679544E0 0x28 Unitytls_errorstate_raise_error ( 000186597660 ModelClassType unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error_t unitytls_errorstate_raise_error_t Pointer )
            value.Unitytls_key_get_ref                      = GetObject<unitytls_key_get_ref_t>(new IntPtr(p + 0x030), ReversePrism.DataModels.unitytls_key_get_ref_t.FromPointer); // 024667954500 0x30 Unitytls_key_get_ref        ( 000186598020 ModelClassType unitytls_key_get_ref_t unitytls_key_get_ref_t unitytls_key_get_ref_t Pointer )
            value.Unitytls_key_parse_der                    = GetObject<unitytls_key_parse_der_t>(new IntPtr(p + 0x038), ReversePrism.DataModels.unitytls_key_parse_der_t.FromPointer); // 024667954520 0x38 Unitytls_key_parse_der      ( 000186598500 ModelClassType unitytls_key_parse_der_t unitytls_key_parse_der_t unitytls_key_parse_der_t Pointer )
            value.Unitytls_key_parse_pem                    = GetObject<unitytls_key_parse_pem_t>(new IntPtr(p + 0x040), ReversePrism.DataModels.unitytls_key_parse_pem_t.FromPointer); // 024667954540 0x40 Unitytls_key_parse_pem      ( 0001865989F0 ModelClassType unitytls_key_parse_pem_t unitytls_key_parse_pem_t unitytls_key_parse_pem_t Pointer )
            value.Unitytls_key_free                         = GetObject<unitytls_key_free_t>(new IntPtr(p + 0x048), ReversePrism.DataModels.unitytls_key_free_t.FromPointer); // 024667954560 0x48 Unitytls_key_free           ( 000186597B60 ModelClassType unitytls_key_free_t unitytls_key_free_t unitytls_key_free_t Pointer )
            value.Unitytls_x509_export_der                  = GetObject<unitytls_x509_export_der_t>(new IntPtr(p + 0x050), ReversePrism.DataModels.unitytls_x509_export_der_t.FromPointer); // 024667954580 0x50 Unitytls_x509_export_der    ( 00018659D840 ModelClassType unitytls_x509_export_der_t unitytls_x509_export_der_t unitytls_x509_export_der_t Pointer )
            value.Unitytls_x509list_get_ref                 = GetObject<unitytls_x509list_get_ref_t>(new IntPtr(p + 0x058), ReversePrism.DataModels.unitytls_x509list_get_ref_t.FromPointer); // 0246679545A0 0x58 Unitytls_x509list_get_ref   ( 00018659F120 ModelClassType unitytls_x509list_get_ref_t unitytls_x509list_get_ref_t unitytls_x509list_get_ref_t Pointer )
            value.Unitytls_x509list_get_x509                = GetObject<unitytls_x509list_get_x509_t>(new IntPtr(p + 0x060), ReversePrism.DataModels.unitytls_x509list_get_x509_t.FromPointer); // 0246679545C0 0x60 Unitytls_x509list_get_x509  ( 00018659F590 ModelClassType unitytls_x509list_get_x509_t unitytls_x509list_get_x509_t unitytls_x509list_get_x509_t Pointer )
            value.Unitytls_x509list_create                  = GetObject<unitytls_x509list_create_t>(new IntPtr(p + 0x068), ReversePrism.DataModels.unitytls_x509list_create_t.FromPointer); // 0246679545E0 0x68 Unitytls_x509list_create    ( 00018659E720 ModelClassType unitytls_x509list_create_t unitytls_x509list_create_t unitytls_x509list_create_t Pointer )
            value.Unitytls_x509list_append                  = GetObject<unitytls_x509list_append_t>(new IntPtr(p + 0x070), ReversePrism.DataModels.unitytls_x509list_append_t.FromPointer); // 024667954600 0x70 Unitytls_x509list_append    ( 00018659E220 ModelClassType unitytls_x509list_append_t unitytls_x509list_append_t unitytls_x509list_append_t Pointer )
            value.Unitytls_x509list_append_der              = GetObject<unitytls_x509list_append_der_t>(new IntPtr(p + 0x078), ReversePrism.DataModels.unitytls_x509list_append_der_t.FromPointer); // 024667954620 0x78 Unitytls_x509list_append_der ( 00018659DD20 ModelClassType unitytls_x509list_append_der_t unitytls_x509list_append_der_t unitytls_x509list_append_der_t Pointer )
            value.Unitytls_x509list_append_pem              = GetObject<unitytls_x509list_append_der_t>(new IntPtr(p + 0x080), ReversePrism.DataModels.unitytls_x509list_append_der_t.FromPointer); // 024667954640 0x80 Unitytls_x509list_append_pem ( 00018659DD20 ModelClassType unitytls_x509list_append_der_t unitytls_x509list_append_der_t unitytls_x509list_append_der_t Pointer )
            value.Unitytls_x509list_free                    = GetObject<unitytls_x509list_free_t>(new IntPtr(p + 0x088), ReversePrism.DataModels.unitytls_x509list_free_t.FromPointer); // 024667954660 0x88 Unitytls_x509list_free      ( 00018659EC20 ModelClassType unitytls_x509list_free_t unitytls_x509list_free_t unitytls_x509list_free_t Pointer )
            value.Unitytls_x509verify_default_ca            = GetObject<unitytls_x509verify_default_ca_t>(new IntPtr(p + 0x090), ReversePrism.DataModels.unitytls_x509verify_default_ca_t.FromPointer); // 024667954680 0x90 Unitytls_x509verify_default_ca ( 00018659FAB0 ModelClassType unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca_t unitytls_x509verify_default_ca_t Pointer )
            value.Unitytls_x509verify_explicit_ca           = GetObject<unitytls_x509verify_explicit_ca_t>(new IntPtr(p + 0x098), ReversePrism.DataModels.unitytls_x509verify_explicit_ca_t.FromPointer); // 0246679546A0 0x98 Unitytls_x509verify_explicit_ca ( 00018659FF90 ModelClassType unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca_t unitytls_x509verify_explicit_ca_t Pointer )
            value.Unitytls_tlsctx_create_server             = GetObject<unitytls_tlsctx_create_server_t>(new IntPtr(p + 0x0A0), ReversePrism.DataModels.unitytls_tlsctx_create_server_t.FromPointer); // 0246679546C0 0xA0 Unitytls_tlsctx_create_server ( 0001865998C0 ModelClassType unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server_t unitytls_tlsctx_create_server_t Pointer )
            value.Unitytls_tlsctx_create_client             = GetObject<unitytls_tlsctx_create_client_t>(new IntPtr(p + 0x0A8), ReversePrism.DataModels.unitytls_tlsctx_create_client_t.FromPointer); // 0246679546E0 0xA8 Unitytls_tlsctx_create_client ( 0001865993E0 ModelClassType unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client_t unitytls_tlsctx_create_client_t Pointer )
            value.Unitytls_tlsctx_server_require_client_authentication = GetObject<unitytls_tlsctx_server_require_client_authentication_t>(new IntPtr(p + 0x0B0), ReversePrism.DataModels.unitytls_tlsctx_server_require_client_authentication_t.FromPointer); // 024667954700 0xB0 Unitytls_tlsctx_server_require_client_authentication ( 00018659BAE0 ModelClassType unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication_t unitytls_tlsctx_server_require_client_authentication_t Pointer )
            value.Unitytls_tlsctx_set_certificate_callback  = GetObject<unitytls_tlsctx_set_certificate_callback_t>(new IntPtr(p + 0x0B8), ReversePrism.DataModels.unitytls_tlsctx_set_certificate_callback_t.FromPointer); // 024667954720 0xB8 Unitytls_tlsctx_set_certificate_callback ( 00018659BFD0 ModelClassType unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback_t unitytls_tlsctx_set_certificate_callback_t Pointer )
            value.Unitytls_tlsctx_set_trace_callback        = GetObject<unitytls_tlsctx_set_trace_callback_t>(new IntPtr(p + 0x0C0), ReversePrism.DataModels.unitytls_tlsctx_set_trace_callback_t.FromPointer); // 024667954740 0xC0 Unitytls_tlsctx_set_trace_callback ( 00018659C940 ModelClassType unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback_t unitytls_tlsctx_set_trace_callback_t Pointer )
            value.Unitytls_tlsctx_set_x509verify_callback   = GetObject<unitytls_tlsctx_set_x509verify_callback_t>(new IntPtr(p + 0x0C8), ReversePrism.DataModels.unitytls_tlsctx_set_x509verify_callback_t.FromPointer); // 024667954760 0xC8 Unitytls_tlsctx_set_x509verify_callback ( 00018659CE60 ModelClassType unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback_t unitytls_tlsctx_set_x509verify_callback_t Pointer )
            value.Unitytls_tlsctx_set_supported_ciphersuites = GetObject<unitytls_tlsctx_set_supported_ciphersuites_t>(new IntPtr(p + 0x0D0), ReversePrism.DataModels.unitytls_tlsctx_set_supported_ciphersuites_t.FromPointer); // 024667954780 0xD0 Unitytls_tlsctx_set_supported_ciphersuites ( 00018659C4C0 ModelClassType unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites_t unitytls_tlsctx_set_supported_ciphersuites_t Pointer )
            value.Unitytls_tlsctx_get_ciphersuite           = GetObject<unitytls_tlsctx_get_ciphersuite_t>(new IntPtr(p + 0x0D8), ReversePrism.DataModels.unitytls_tlsctx_get_ciphersuite_t.FromPointer); // 0246679547A0 0xD8 Unitytls_tlsctx_get_ciphersuite ( 00018659A2A0 ModelClassType unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite_t unitytls_tlsctx_get_ciphersuite_t Pointer )
            value.Unitytls_tlsctx_get_protocol              = GetObject<unitytls_tlsctx_get_protocol_t>(new IntPtr(p + 0x0E0), ReversePrism.DataModels.unitytls_tlsctx_get_protocol_t.FromPointer); // 0246679547C0 0xE0 Unitytls_tlsctx_get_protocol ( 00018659A7A0 ModelClassType unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol_t unitytls_tlsctx_get_protocol_t Pointer )
            value.Unitytls_tlsctx_process_handshake         = GetObject<unitytls_tlsctx_process_handshake_t>(new IntPtr(p + 0x0E8), ReversePrism.DataModels.unitytls_tlsctx_process_handshake_t.FromPointer); // 0246679547E0 0xE8 Unitytls_tlsctx_process_handshake ( 00018659B140 ModelClassType unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake_t unitytls_tlsctx_process_handshake_t Pointer )
            value.Unitytls_tlsctx_read                      = GetObject<unitytls_tlsctx_read_t>(new IntPtr(p + 0x0F0), ReversePrism.DataModels.unitytls_tlsctx_read_t.FromPointer); // 024667954800 0xF0 Unitytls_tlsctx_read        ( 00018659B620 ModelClassType unitytls_tlsctx_read_t unitytls_tlsctx_read_t unitytls_tlsctx_read_t Pointer )
            value.Unitytls_tlsctx_write                     = GetObject<unitytls_tlsctx_write_t>(new IntPtr(p + 0x0F8), ReversePrism.DataModels.unitytls_tlsctx_write_t.FromPointer); // 024667954820 0xF8 Unitytls_tlsctx_write       ( 00018659D340 ModelClassType unitytls_tlsctx_write_t unitytls_tlsctx_write_t unitytls_tlsctx_write_t Pointer )
            value.Unitytls_tlsctx_notify_close              = GetObject<unitytls_tlsctx_notify_close_t>(new IntPtr(p + 0x100), ReversePrism.DataModels.unitytls_tlsctx_notify_close_t.FromPointer); // 024667954840 0x100 Unitytls_tlsctx_notify_close ( 00018659ACA0 ModelClassType unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close_t unitytls_tlsctx_notify_close_t Pointer )
            value.Unitytls_tlsctx_free                      = GetObject<unitytls_tlsctx_free_t>(new IntPtr(p + 0x108), ReversePrism.DataModels.unitytls_tlsctx_free_t.FromPointer); // 024667954860 0x108 Unitytls_tlsctx_free        ( 000186599DA0 ModelClassType unitytls_tlsctx_free_t unitytls_tlsctx_free_t unitytls_tlsctx_free_t Pointer )
            value.Unitytls_random_generate_bytes            = GetObject<unitytls_random_generate_bytes_t>(new IntPtr(p + 0x110), ReversePrism.DataModels.unitytls_random_generate_bytes_t.FromPointer); // 024667954880 0x110 Unitytls_random_generate_bytes ( 000186598EC0 ModelClassType unitytls_random_generate_bytes_t unitytls_random_generate_bytes_t unitytls_random_generate_bytes_t Pointer )

            return value;
        }
    }
}
