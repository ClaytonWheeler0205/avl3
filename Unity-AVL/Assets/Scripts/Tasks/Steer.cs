using UnityEngine;

public class Steer : TaskInterface
{
    const float steerSpeed = 3f;
    const float acceptableAngleThreshold = 0.5f;

    public void Execute(DeviceRegistry devices)
    {
        var angle = devices.compass[0];

        if (angle > -2f && angle < 2) {
            devices.memory[4] = 0f;
        } else if (angle > 88f && angle < 92f) {
            devices.memory[4] = 1f;
        } else if ((angle > 178 && angle < 180) || (angle < -178f && angle > -180f)) {
            devices.memory[4] = 2f;
        } else if (angle > -92f && angle < -88f) {
            devices.memory[4] = 3f;
        } else {
            devices.memory[4] = 4f;
        }

        if (devices.memory[3] == 0f) {
            if (angle > (acceptableAngleThreshold) && angle < 180f) turnLeft(devices);
            if (angle < (-acceptableAngleThreshold) && angle > -180f) turnRight(devices);
        }

        if (devices.memory[3] == 1f) {
            if ((angle > -180f && angle < -90f) || (angle > 90f + acceptableAngleThreshold && angle < 180f)) turnLeft(devices);
            if ((angle > -90f && angle < 0f) || (angle > 0f && angle < 90f - acceptableAngleThreshold)) turnRight(devices);
        }

        if (devices.memory[3] == 2f) {
            if (angle < (0f) && angle > -180f + acceptableAngleThreshold) turnLeft(devices);
            if (angle > (0f) && angle < 180f - acceptableAngleThreshold) turnRight(devices);
        }

        if (devices.memory[3] == 3f) {
            if ((angle > -90f + acceptableAngleThreshold && angle < 0f) || (angle > 0f && angle < 90f)) turnLeft(devices);
            if ((angle > -180f && angle < -90f - acceptableAngleThreshold) || (angle > 90f && angle < 180f)) turnRight(devices);
        }
    }

    public void turnRight(DeviceRegistry devices) {
        devices.steeringControl[0] = 1f;
        devices.steeringControl[1] = steerSpeed;
    }

    public void turnLeft(DeviceRegistry devices) {
        devices.steeringControl[0] = 1f;
        devices.steeringControl[1] = -steerSpeed;
    }
}