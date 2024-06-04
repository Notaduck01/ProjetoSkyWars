using UnityEngine;

public class ChessPieceMovement : MonoBehaviour
{
    public float moveSpeed = 1f;
    private Vector2 gridSize = new Vector2(8, 8);
    private Vector2 piecePosition;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MovePiece(Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            MovePiece(Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            MovePiece(Vector2.down);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            MovePiece(Vector2.right);
        }
    }

    void MovePiece(Vector2 direction)
    {
        piecePosition += direction;
        piecePosition = new Vector2(Mathf.Clamp(piecePosition.x, 0, gridSize.x - 1), Mathf.Clamp(piecePosition.y, 0, gridSize.y - 1));
        transform.position = piecePosition;
    }
}