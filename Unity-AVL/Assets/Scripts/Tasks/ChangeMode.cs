using UnityEngine;

public class ChangeMode : TaskInterface
{
    const float coordinateThreshold = 1f;
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
        float coordinateThreshold = 0.5f;
        float frontLidarDistance = devices.memory[9];

        if (mode == 0f && (lon >= 27f - coordinateThreshold && lon <= 27f + coordinateThreshold)) {
            devices.memory[0] = 1f;
            devices.memory[3] = east;
        }

        if (mode == 1f && (lat > 16.5)) {
            devices.memory[0] = 2f;
            devices.memory[3] = south;
        }

        if (mode == 2f && (lon < 14)) {
            devices.memory[0] = 3f;
            devices.memory[3] = west;
        }

        if (mode == 3f && lat < -12.5) {
            devices.memory[0] = 4f;
            devices.memory[3] = south;
        }

        if (mode == 4f && lon < 7.25) {
            devices.memory[0] = 5f;
            devices.memory[3] = east;
        }

        if (mode == 5f && lat > 16.5) {
            devices.memory[0] = 6f;
            devices.memory[3] = south;
        }

        if (mode == 6f && lon < -6) {
            devices.memory[0] = 7f;
            devices.memory[3] = west;
        }

        if (mode == 7f && lat < -12.5) {
            devices.memory[0] = 8f;
            devices.memory[3] = south;
        }

        if (mode == 8f && lon < -12.60) {
            devices.memory[0] = 9f;
            devices.memory[3] = east;
        }

        if (mode == 9f && lat > 16.5) {
            devices.memory[0] = 10f;
            devices.memory[3] = south;
        }

        if (mode == 10f && lon < -25.75) {
            devices.memory[0] = 11f;
            devices.memory[3] = west;
        }

        if (mode == 11f && lat < -13) {
            devices.memory[0] = 12f;
        }

        if ((mode == 1f || mode == 5f || mode == 9f) && (devices.memory[4] == east) && (lat > -13.5 && lat < 15) && devices.memory[10] == 1f) {
            devices.memory[0] = 13f;
            devices.memory[3] = south;
        }

        if ((mode == 3f || mode == 7f || mode == 11f) && (lat > -13.5 && lat < 13.5) && devices.memory[10] == 1f) {
            devices.memory[0] = 14f;
            devices.memory[3] = north;
        }

        if ((mode == 13f || mode == 14f) && frontLidarDistance < 2.5f) {
            devices.memory[0] = 20f;
        }

        // Debug.Log($"MODE: {mode}");
    }
}