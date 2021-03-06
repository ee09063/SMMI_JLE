﻿namespace Utilities
{
    using UnityEngine;

    public static class PanelHelper
    {
        public enum WindowPositions
        {
            Center,
            Right,
            Up,
            Down,
            Left
        }

        public enum PanelType
        {
            BuildMode,
            Instruction,
            SaveLoad,
            EndLevel
        }

        public static void GetAnchorsForWindowPosition(WindowPositions targetPosition, out Vector2 anchorMin, out Vector2 anchorMax, PanelType type)
        {
            switch (targetPosition)
            {
                case WindowPositions.Right:
                    if (type == PanelType.Instruction)
                    {
                        anchorMin = new Vector2(1, 0.25f);
                        anchorMax = new Vector2(1.45f, 0.8f);
                    }
                    else if (type == PanelType.BuildMode)
                    {
                        anchorMin = Vector2.right;
                        anchorMax = new Vector2(1.2f, 1);
                    }
                    else
                    {
                        anchorMin = new Vector2(1f, 0f);
                        anchorMax = new Vector2(1f, 2f);
                    }
                    break;

                case WindowPositions.Up:
                    if (type == PanelType.Instruction)
                    {
                        anchorMin = Vector2.up;
                        anchorMax = new Vector2(1, 2);
                    }
                    else if (type == PanelType.BuildMode)
                    {
                        anchorMin = Vector2.up;
                        anchorMax = new Vector2(1, 2);
                    }
                    else if (type == PanelType.SaveLoad)
                    {
                        anchorMin = new Vector2(0, 1);
                        anchorMax = new Vector2(1, 2);
                    }
                    else
                    {
                        anchorMin = new Vector2(0, 1);
                        anchorMax = new Vector2(1, 2);
                    }
                    break;

                case WindowPositions.Down:
                    if (type == PanelType.Instruction)
                    {
                        anchorMin = new Vector2(0, -1);
                        anchorMax = Vector2.right;
                    }
                    else if (type == PanelType.SaveLoad)
                    {
                        anchorMin = new Vector2(0, -1);
                        anchorMax = Vector2.right;
                    }
                    else
                    {
                        anchorMin = new Vector2(0, -1);
                        anchorMax = new Vector2(1, 0);
                    }
                    break;

                case WindowPositions.Left:
                    if (type == PanelType.Instruction)
                    {
                        anchorMin = new Vector2(-0.2f, 0.86f);
                        anchorMax = new Vector2(0, 1);
                    }
                    else if (type == PanelType.BuildMode)
                    {
                        anchorMin = new Vector2(-0.2f, 0.86f);
                        anchorMax = new Vector2(0, 1);
                    }
                    else
                    {
                        anchorMin = new Vector2(-1, 0);
                        anchorMax = new Vector2(0, 1);
                    }
                    break;

                default: // CENTER
                    if (type == PanelType.Instruction)
                    {
                        anchorMin = new Vector2(0.35f, 0.25f);
                        anchorMax = new Vector2(0.8f, 0.8f);
                    }
                    else if (type == PanelType.BuildMode)
                    {
                        anchorMin = new Vector2(0, 0.86f);
                        anchorMax = new Vector2(0.2f, 1);
                    }
                    else if (type == PanelType.SaveLoad)
                    {
                        anchorMin = new Vector2(0, 0);
                        anchorMax = new Vector2(1f, 1f);
                    }
                    else
                    {
                        anchorMin = new Vector2(0, 0);
                        anchorMax = new Vector2(1f, 1f);
                    }
                    break;
            }
        }

        public static void LerpRectTransformAnchors(RectTransform rectTransform, Vector2 targetMin, Vector2 targetMax, float speed)
        {
            rectTransform.anchorMin = Vector2.Lerp(rectTransform.anchorMin, targetMin, speed);
            rectTransform.anchorMax = Vector2.Lerp(rectTransform.anchorMax, targetMax, speed);
        }
    }
}
