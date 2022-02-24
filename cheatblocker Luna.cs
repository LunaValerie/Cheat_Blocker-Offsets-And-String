Luna UI !
Anti-Debug : isDebuggerPresent
Crash Trace : easy handle already used in multi handle
Cb.cbm : SetErrorCode : Duplicate ErrorCode : %d ( %s )
Cb.cbm : CPT PrintLog Failed : OpenFile Wrtire [ %s ]
Cb.cbm : PrintLog : Unknown ErrorCode : %d
Cb.cbm : ??_7
Cb.cbm : ___ImageBase
Cb.cbm : [ Exception ] - Failed ( %d )
Cb.cbm : Exports
Cb.cbm : [ Exception ] - Failed to get QueryPerformanceCounter
Cb.cbm : [ ModuleAPI::Initialize ]
Cb.cbm : [ Exception ] - Failed to get CreateThread
Cb.cbm : QueryPerformanceCounter
Cb.cbm : CreateThread
Cb.cbm : GetCurrentThread
Cb.cbm : USE COMPULSION CALL
Cb.cbm : SetUnhandledExceptionFilter
Cb.cbm : DELETE PREV COMPULSION CALL
Cb.cbm : %02x
Cb.cbm : [ Exception ] - Invalid stream flag value ( %d )
Cb.cbm : [ Crypto::Decryption ]
Cb.cbm : [ Crypto::EncryptionEx ]
Cb.cbm : [ Crypto::Encryption ]
Cb.cbm : [ Exception ] - _PopFreeDataAddr result is null
Cb.cbm : [ MemoryPoolBase::AllocData ]
Cb.cbm : bad allocation

CB.cbm+963C4

CB.cbm+27194C

CB.cbm+51C0DC

ntdll.RtlImageNtHeaderEx+7F:
773BE617 - 89 4D FC  - mov [ebp-04],ecx
773BE61A - BA 4D5A0000 - mov edx,00005A4D
773BE61F - 66 39 10  - cmp [eax],dx <<
773BE622 - 0F85 9D000000 - jne ntdll.RtlImageNtHeaderEx+125
773BE628 - 8B 48 3C  - mov ecx,[eax+3C]

EAX=6AF50000
EBX=00000000
ECX=00000000
EDX=00005A4D
ESI=00000000
EDI=00000000
ESP=1991DB38
EBP=1991DB6C
EIP=773BE622


First seen:13:20:14
Last seen:13:20:14