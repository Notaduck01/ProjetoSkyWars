using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GridMovementLimits {
  public float minX;
  public float maxX;
  public float minY;
  public float maxY;

  public GridMovementLimits(float minX, float maxX, float minY, float maxY) {
    this.minX = minX;
    this.maxX = maxX;
    this.minY = minY;
    this.maxY = maxY;
  }
}