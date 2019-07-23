using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{
    public class PlayerModel
    {
        public PlayerModel(PlayerColor playerColor, InputActionMap actionMap)
        {
            this.playerColor = playerColor;
            this.actionMap = actionMap;
        }
        public PlayerColor playerColor;
        public InputActionMap actionMap;
        public int gamepadId = -1;
    }

    [SerializeField]
    private BlockManager blockManager = null;

    private Inputs input;
    public List<PlayerModel> mapToColor = new List<PlayerModel>();

    public event Action<PlayerColor> Left;
    public event Action<PlayerColor> Right;
    public event Action<PlayerColor> Down;
    public event Action<PlayerColor> RotateClockwise;
    public event Action<PlayerColor> RotateCounterClockwise;

    private void Awake()
    {
        input = new Inputs();
    }

    public void SetPlayers(PlayerColor players)
    {
        if (players.HasFlag(PlayerColor.Red) ||
            players.HasFlag(PlayerColor.Green) ||
            players.HasFlag(PlayerColor.Blue) || 
            players.HasFlag(PlayerColor.Yellow))
        {
            mapToColor.Add(new PlayerModel(PlayerColor.Red, input.RBrown));
            mapToColor.Add(new PlayerModel(PlayerColor.Green, input.ROrange));
            mapToColor.Add(new PlayerModel(PlayerColor.Blue, input.RTeal));
            mapToColor.Add(new PlayerModel(PlayerColor.Yellow, input.RPurple));

            for (int i = 0; i < mapToColor.Count; i++)
            {
                int index = i;
                PlayerModel pair = mapToColor[i];
                pair.actionMap.GetAction("Left").performed += x => OnLeft(x, index);
                pair.actionMap.GetAction("Right").performed += x => OnRight(x, index);
                pair.actionMap.GetAction("Down").performed += x => OnDown(x, index);
                pair.actionMap.GetAction("RotateClockwise").performed += x => OnRotateClockwise(x, index);
                pair.actionMap.GetAction("RotateCounterClockwise").performed += x => OnRotateCounterClockwise(x, index);
            }

        }
        else
        {
            mapToColor.Add(new PlayerModel(PlayerColor.Brown, input.XBoxOne));
            mapToColor.Add(new PlayerModel(PlayerColor.Orange, input.XBoxOne));
            mapToColor.Add(new PlayerModel(PlayerColor.Teal, input.XBoxOne));
            mapToColor.Add(new PlayerModel(PlayerColor.Purple, input.XBoxOne));

            input.XBoxOne.Left.performed += OnLeftXBox;
            input.XBoxOne.Right.performed += OnRightXBox;
            input.XBoxOne.Down.performed += OnDownXBox;
            input.XBoxOne.RotateClockwise.performed += OnRotateClockwiseXBox;
            input.XBoxOne.RotateCounterClockwise.performed += OnRotateCounterClockwiseXBox;

        }


        OnEnable();
    }

    private void OnEnable()
    {
        foreach (var pair in mapToColor)
        {
            pair.actionMap.GetAction("Left").Enable();
            pair.actionMap.GetAction("Right").Enable();
            pair.actionMap.GetAction("Down").Enable();
            pair.actionMap.GetAction("RotateClockwise").Enable();
            pair.actionMap.GetAction("RotateCounterClockwise").Enable();
        }
    }
    private void OnDisable()
    {
        foreach (var pair in mapToColor)
        {
            pair.actionMap.GetAction("Left").Disable();
            pair.actionMap.GetAction("Right").Disable();
            pair.actionMap.GetAction("Down").Disable();
            pair.actionMap.GetAction("RotateClockwise").Disable();
            pair.actionMap.GetAction("RotateCounterClockwise").Disable();
        }
    }










    private void OnLeft(InputAction.CallbackContext context, int id)
    {
        PlayerColor color = mapToColor[id].playerColor;
        Left?.Invoke(color);
    }

    private void OnRight(InputAction.CallbackContext context, int id)
    {
        PlayerColor color = mapToColor[id].playerColor;
        Right?.Invoke(color);
    }

    private void OnDown(InputAction.CallbackContext context, int id)
    {
        PlayerColor color = mapToColor[id].playerColor;
        Down?.Invoke(color);
    }

    private void OnRotateCounterClockwise(InputAction.CallbackContext context, int id)
    {
        PlayerColor color = mapToColor[id].playerColor;
        RotateClockwise?.Invoke(color);
    }

    private void OnRotateClockwise(InputAction.CallbackContext context, int id)
    {
        PlayerColor color = mapToColor[id].playerColor;
        RotateCounterClockwise?.Invoke(color);
    }



    private void OnLeftXBox(InputAction.CallbackContext context)
    {
        PlayerModel model = GetXboxGamepad(Gamepad.current.id);
        if (model == null) return;
        PlayerColor color = model.playerColor;
        Left?.Invoke(color);
    }

    private void OnRightXBox(InputAction.CallbackContext context)
    {
        PlayerModel model = GetXboxGamepad(Gamepad.current.id);
        if (model == null) return;
        PlayerColor color = model.playerColor;
        Right?.Invoke(color);
    }

    private void OnDownXBox(InputAction.CallbackContext context)
    {
        PlayerModel model = GetXboxGamepad(Gamepad.current.id);
        if (model == null) return;
        PlayerColor color = model.playerColor;
        Down?.Invoke(color);
    }

    private void OnRotateCounterClockwiseXBox(InputAction.CallbackContext context)
    {
        PlayerModel model = GetXboxGamepad(Gamepad.current.id);
        if (model == null) return;
        PlayerColor color = model.playerColor;
        RotateClockwise?.Invoke(color);
    }

    private void OnRotateClockwiseXBox(InputAction.CallbackContext context)
    {
        PlayerModel model = GetXboxGamepad(Gamepad.current.id);
        if (model == null) return;
        PlayerColor color = model.playerColor;
        RotateCounterClockwise?.Invoke(color);
    }

    private PlayerModel GetXboxGamepad(int id)
    {
        PlayerModel model = mapToColor.Find(x => x.gamepadId == Gamepad.current.id);
        if (model == null)
        {
            for (int i = 0; i < mapToColor.Count; i++)
            {
                PlayerModel playerModel = mapToColor[i];
                if (playerModel.gamepadId == -1)
                {
                    playerModel.gamepadId = id;
                    return playerModel;
                }
            }
        }
        return model;
    }


}
