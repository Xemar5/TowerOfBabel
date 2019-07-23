using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "ColorCellDefinition", menuName = "Create Color Cell Definition")]
public class ColorCellDefinition : ScriptableObject
{

    public List<Sprite> cellSprites = new List<Sprite>();

}
