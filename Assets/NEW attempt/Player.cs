using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridMovement : MonoBehaviour {
  // Allows you to hold down a key for movement.
  [SerializeField] private bool isRepeatedMovement = false;
  // Time in seconds to move between one grid position and the next.
  [SerializeField] private float moveDuration = 0.1f;
  // The size of the grid
  [SerializeField] private float gridSize = 1f;

  [SerializeField] public float minX = -10f;
  [SerializeField] public float maxX = 10f;
  [SerializeField] public float minY = -10f;
  [SerializeField] public float maxY = 10f;

  private bool isMoving = false;
  private Vector2 startPosition;
  private Vector2 endPosition;

  private void Update() {
    if (!isMoving) {
      if (isRepeatedMovement) {
        if (Input.GetKey(KeyCode.UpArrow)) {
          StartCoroutine(Move(Vector2.up));
        } else if (Input.GetKey(KeyCode.DownArrow)) {
          StartCoroutine(Move(Vector2.down));
        } else if (Input.GetKey(KeyCode.LeftArrow)) {
          StartCoroutine(Move(Vector2.left));
        } else if (Input.GetKey(KeyCode.RightArrow)) {
          StartCoroutine(Move(Vector2.right));
        }
      } else {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
          StartCoroutine(Move(Vector2.up));
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
          StartCoroutine(Move(Vector2.down));
        } else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
          StartCoroutine(Move(Vector2.left));
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) {
          StartCoroutine(Move(Vector2.right));
        }
      }
    }
  }

  private IEnumerator Move(Vector2 direction) {
    isMoving = true;
    startPosition = transform.position;
    endPosition = startPosition + (direction * gridSize);

    endPosition = new Vector2(
      Mathf.Clamp(endPosition.x, minX, maxX),
      Mathf.Clamp(endPosition.y, minY, maxY)
    );

    float elapsedTime = 0;
    while (elapsedTime < moveDuration) {
      elapsedTime += Time.deltaTime;
      float percent = elapsedTime / moveDuration;
      transform.position = Vector2.Lerp(startPosition, endPosition, percent);
      yield return null;
    }

    transform.position = endPosition;
    isMoving = false;
  }
}