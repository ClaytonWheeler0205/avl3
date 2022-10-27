using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCamera : TaskInterface
{
    /// <summary>
    /// Checks to see if the array of ints and floats have equal values (ex 10 == 10f)
    /// </summary>
    /// <param name="ints">The array of integers to compare</param>
    /// <param name="floats">The array of floats to compare</param>
    /// <returns>Returns true if the arrays contain the same relative values, and false otherwise.</returns>
    public bool equal(int[] ints, float[] floats) {
        if (ints.Length != floats.Length) return false;
        for (int i = 0; i < ints.Length; i++) {
            if (floats[i] != ints[i]) return false;
        }
        return true;
    }
    public void Execute(DeviceRegistry devices) {
        // Get rgb values for pedestrians and cars
        int[] pedestrian = {255, 0, 7};
        int[] obstacle_car_blue = {0, 124, 255};
        int[] obstacle_car_green = {0, 255, 27};
        int[] obstacle_car_purple = { 172, 0, 255 };
        int[] obstacle_car_gray = {192, 192, 192};
        int[] obstacle_car_brown = { 101, 33, 0 };

        //Initialize camera arrays to read color values
        const int bottom_row = 3;

        float[] bottom_center = { devices.pixels[bottom_row, 7, 0], devices.pixels[bottom_row, 7, 1], devices.pixels[bottom_row, 7, 2] };        // Bottom center
        float[] bottom_center_m1 = { devices.pixels[4, 1, 0], devices.pixels[4, 1, 1], devices.pixels[4, 1, 2] };        // Bottom center
        float[] bottom_left_p1 = { devices.pixels[bottom_row, 1, 0], devices.pixels[bottom_row, 1, 1], devices.pixels[bottom_row, 1, 2] };       // Bottom right plus 1
        float[] bottom_left_p3 = { devices.pixels[bottom_row, 3, 0], devices.pixels[bottom_row, 3, 1], devices.pixels[bottom_row, 3, 2] };       // Bottom left plus 3
        float[] bottom_right_m0 = { devices.pixels[bottom_row, 14, 0], devices.pixels[bottom_row, 11, 1], devices.pixels[bottom_row, 14, 2] };   // Bottom right minus 0
        float[] bottom_right_m1 = { devices.pixels[bottom_row, 13, 0], devices.pixels[bottom_row, 13, 1], devices.pixels[bottom_row, 13, 2] };   // Bottom right minus 1        
    }

}
