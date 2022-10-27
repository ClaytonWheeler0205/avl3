using UnityEngine;

public class Move : TaskInterface
{
    const float moveSpeed = 2f;
    const float north = 0f;
    const float east = 1f;
    const float south = 2f;
    const float west = 3f;
    public void Execute(DeviceRegistry devices)
    {
        float lat = devices.memory[1];
        float lon = devices.memory[2];
        float mode = devices.memory[0];
        float direction = devices.memory[4];

        if (mode == 0f) {
            if (lon < 27.5f) {
                devices.memory[3] = north;
                if (direction == north) {
                    move(devices);
                } else {
                    stop(devices);
                }
            } else if (lon > 26.5f) {
                devices.memory[3] = south;
                if (direction == south) {
                    move(devices);
                } else {
                    stop(devices);
                }
            }
        } else if (mode == 1f) {
            if (direction == east) {
                move(devices);
            } else {
                stop(devices);
            }
        } else if (mode == 2f) {
            if (direction == south) {
                move(devices);
            } else {
                stop(devices);
            }
        } else if (mode == 3f) {
            if (direction == west) {
                move(devices);
            } else {
                stop(devices);
            }
        } else if (mode == 4f) {
            if (direction == south) {
                move(devices);
            } else {
                stop(devices);
            }
        } else if (mode == 5f) {
            if (direction == east) {
                move(devices);
            } else {
                stop(devices);
            }
        } else if (mode == 6f) {
            if (direction == south) {
                move(devices);
            } else {
                stop(devices);
            }
        } else if (mode == 7f) {
            if (direction == west) {
                move(devices);
            } else {
                stop(devices);
            }
        } else if (mode == 8f) {
            if (direction == south) {
                move(devices);
            } else {
                stop(devices);
            }
        } else if (mode == 9f) {
            if (direction == east) {
                move(devices);
            } else {
                stop(devices);
            }
        } else if (mode == 10f) {
            if (direction == south) {
                move(devices);
            } else {
                stop(devices);
            }
        } else if (mode == 11f) {
            if (direction == west) {
                move(devices);
            } else {
                stop(devices);
            }
        } else if (mode == 12f) {
            stop(devices);
        } else if (mode == 13f) {
            if (direction == south) {
                move(devices);
            } else {
                stop(devices);
            }
        } else if (mode == 14f) {
            if (direction == north) {
                move(devices);
            } else {
                stop(devices);
            }
        } else {
            stop(devices);
        }

    }

    public void stop(DeviceRegistry devices) {
        devices.speedControl[0] = 1f;
        devices.speedControl[1] = 0f;
        devices.brakeControl[0] = 1f;
        devices.brakeControl[1] = 1f;
    }

    public void move(DeviceRegistry devices) {
        devices.speedControl[0] = 1f;
        devices.speedControl[1] = moveSpeed;
    }
}