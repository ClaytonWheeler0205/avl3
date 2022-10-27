using UnityEngine;

public class GetCoordinates : TaskInterface
{
    public void Execute(DeviceRegistry devices)
    {
        var lat = devices.gps[0];
        var lon = devices.gps[1];
        
        devices.memory[1] = lat;
        devices.memory[2] = lon;
    }
}