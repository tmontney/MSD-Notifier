Class Win32_LogicalDisk
    Public Property Access As UShort
    Public Property Availability As UShort
    Public Property BlockSize As ULong
    Public Property Caption As String
    Public Property Compressed As Boolean
    Public Property ConfigManagerErrorCode As UInteger
    Public Property ConfigManagerUserConfig As Boolean
    Public Property CreationClassName As String
    Public Property Description As String
    Public Property DeviceID As String
    Public Property DriveType As UInteger
    Public Property ErrorCleared As Boolean
    Public Property ErrorDescription As String
    Public Property ErrorMethodology As String
    Public Property FileSystem As String
    Public Property FreeSpace As ULong
    Public Property InstallDate As Date
    Public Property LastErrorCode As UInteger
    Public Property MaximumComponentLength As UInteger
    Public Property MediaType As UInteger
    Public Property Name As String
    Public Property NumberOfBlocks As ULong
    Public Property PNPDeviceID As String
    Public Property PowerManagementCapabilities As UShort
    Public Property PowerManagementSupported As Boolean
    Public Property ProviderName As String
    Public Property Purpose As String
    Public Property QuotasDisabled As Boolean
    Public Property QuotasIncomplete As Boolean
    Public Property QuotasRebuilding As Boolean
    Public Property Size As ULong
    Public Property Status As String
    Public Property StatusInfo As UShort
    Public Property SupportsDiskQuotas As Boolean
    Public Property SupportsFileBasedCompression As Boolean
    Public Property SystemCreationClassName As String
    Public Property SystemName As String
    Public Property VolumeDirty As Boolean
    Public Property VolumeName As String
    Public Property VolumeSerialNumber As String

    Public Shared Function FromManagementObject(ByVal Obj As Management.ManagementBaseObject) As Win32_LogicalDisk
        Dim r As New Win32_LogicalDisk

        For Each P In r.GetType().GetProperties()
            P.SetValue(r, Obj.Properties.Item(P.Name).Value)
        Next

        Return r
    End Function
End Class

