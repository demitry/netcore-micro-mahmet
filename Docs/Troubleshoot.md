
Severity	Code	Description	Project	File	Line	Suppression State	Details
Error	DT1001	Error response from daemon: driver failed programming external connectivity on endpoint discountdb (e8b281b0dd960baa14c456fb0abb9de6359085c875bc64c9ec8e1826e060272a): Bind for 0.0.0.0:5432 failed: port is already allocated
If the error persists, try restarting Docker Desktop.	docker-compose	C:\Program Files\Microsoft Visual Studio\2022\Community\MSBuild\Sdks\Microsoft.Docker.Sdk\build\Microsoft.VisualStudio.Docker.Compose.targets	425		

```
netstat -ano | findstr :5432
  TCP    0.0.0.0:5432           0.0.0.0:0              LISTENING       15540
  TCP    [::]:5432              [::]:0                 LISTENING       15540
  TCP    [::1]:5432             [::]:0                 LISTENING       9884 

netstat -ano | findstr :5438

tasklist /fi "pid eq 15540"

Image Name                     PID Session Name        Session#    Mem Usage
========================= ======== ================ =========== ============
com.docker.backend.exe       15540 Console                    1    140,224 K

```

Oh, I had eventuras db on this port. 

---------------------------
Microsoft Visual Studio
---------------------------
Containers Tools Extensions

invalid value for "since": failed to parse value as time or duration: "15:31:58".\r\n\r\nFor more troubleshooting information, go to https://aka.ms/DockerToolsTroubleshooting
---------------------------
OK   
---------------------------


---------------------------
Microsoft Visual Studio
---------------------------
Containers Tools Extensions

invalid value for "since": failed to parse value as time or duration: "15:31:58".\r\n\r\nFor more troubleshooting information, go to https://aka.ms/DockerToolsTroubleshooting
---------------------------
OK   
---------------------------

Ok, It is MS bug:

https://github.com/microsoft/DockerTools/issues/419

