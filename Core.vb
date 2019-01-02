Imports System.Management

Module Core

    Sub Main()
        Dim weq_Insertion As WqlEventQuery = New WqlEventQuery("SELECT * FROM __InstanceCreationEvent WITHIN 5 WHERE TargetInstance ISA 'Win32_LogicalDisk'")
        Dim w_Insertion As ManagementEventWatcher = New ManagementEventWatcher(weq_Insertion)
        AddHandler w_Insertion.EventArrived, AddressOf weq_DeviceInsertion
        w_Insertion.Start()

        Dim weq_Removal As WqlEventQuery = New WqlEventQuery("SELECT * FROM __InstanceDeletionEvent WITHIN 2 WHERE TargetInstance ISA 'Win32_LogicalDisk'")
        Dim w_Removal As ManagementEventWatcher = New ManagementEventWatcher(weq_Removal)
        AddHandler w_Removal.EventArrived, AddressOf weq_DeviceRemoval
        w_Removal.Start()

        Console.ReadLine()
    End Sub

    Private Sub weq_DeviceInsertion(sender As Object, e As EventArrivedEventArgs)
        Dim LogDisk As Win32_LogicalDisk = Win32_LogicalDisk.FromManagementObject(e.NewEvent("TargetInstance"))
        Console.WriteLine("Inserted: " & LogDisk.Name)
    End Sub

    Private Sub weq_DeviceRemoval(sender As Object, e As EventArrivedEventArgs)
        Dim LogDisk As Win32_LogicalDisk = Win32_LogicalDisk.FromManagementObject(e.NewEvent("TargetInstance"))
        Console.WriteLine("Removal: " & LogDisk.Name)
    End Sub

End Module
