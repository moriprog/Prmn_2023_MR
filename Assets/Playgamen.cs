using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLinesOnBackplate : MonoBehaviour
{
    public LineRenderer lineRendererPrefab; // Line Rendererのプレハブ
    public Transform backplate; // 背景平面のTransform
    public int gridSize = 6; // グリッドのサイズ
    public float cellSize = 1.0f; // セルのサイズ

    void Start()
    {
        for (int i = 0; i <= gridSize; i++)
        {
            // Create horizontal lines
            LineRenderer horizontalLine = Instantiate(lineRendererPrefab, backplate);
            horizontalLine.positionCount = 2;
            horizontalLine.SetPosition(0, new Vector3(-gridSize * cellSize * 0.5f, 0, i * cellSize - gridSize * cellSize * 0.5f));
            horizontalLine.SetPosition(1, new Vector3(gridSize * cellSize * 0.5f, 0, i * cellSize - gridSize * cellSize * 0.5f));

            // Create vertical lines
            LineRenderer verticalLine = Instantiate(lineRendererPrefab, backplate);
            verticalLine.positionCount = 2;
            verticalLine.SetPosition(0, new Vector3(i * cellSize - gridSize * cellSize * 0.5f, 0, -gridSize * cellSize * 0.5f));
            verticalLine.SetPosition(1, new Vector3(i * cellSize - gridSize * cellSize * 0.5f, 0, gridSize * cellSize * 0.5f));
        }
    }
}
