﻿using ThunderKit.Core.Pipelines;
using UnityEditor;
using UnityEngine;
using static UnityEditor.EditorGUIUtility;

namespace ThunderKit.Core.Editor
{
    [CustomEditor(typeof(Pipeline), true)]
    public class PipelineEditor : ComposableObjectEditor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            stepRect.y += 26;
            if (GUI.Button(stepRect, "Execute"))
            {
                var pipeline = target as Pipeline;
                pipeline?.Execute();
            }
        }
    }
}