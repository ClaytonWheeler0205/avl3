using UnityEngine;

public class GetLidar : TaskInterface
{
    public void Execute(DeviceRegistry devices)
    {
        var forward_lidar = devices.lidar[0];
        var right_lidar_m1 = devices.lidar[3];
        var right_lidar = devices.lidar[4];
        var right_lidar_p1 = devices.lidar[5];
        var rear_lidar = devices.lidar[8];
        var left_lidar = devices.lidar[12];
        
        devices.memory[9] = forward_lidar;

        if (right_lidar_m1 > 4.5f && right_lidar > 4.5f && right_lidar_p1 > 4.5f)
        {
            devices.memory[10] = 1f;
        } else {
            devices.memory[10] = 0f;
        }
    }
}