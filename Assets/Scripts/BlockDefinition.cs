using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "BlockDefinition", menuName = "Create Block Definition")]
public class BlockDefinition : ScriptableObject
{
    public List<Vector2Int> cellOffsets;
}
