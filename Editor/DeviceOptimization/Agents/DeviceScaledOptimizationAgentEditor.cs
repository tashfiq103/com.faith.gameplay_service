﻿namespace com.faith.GameplayService {

    using UnityEngine;
    using UnityEditor;

    [CustomEditor(typeof(DeviceScaleOptimizationAgent))]
    public class DeviceScaledOptimizationAgentEditor : Editor
    {

        private DeviceScaleOptimizationAgent Reference;

        /// <summary>
        /// This function is called when the object becomes enabled and active.
        /// </summary>
        void OnEnable()
        {
            Reference = (DeviceScaleOptimizationAgent)target;
        }

        public override void OnInspectorGUI()
        {

            serializedObject.Update();

            Reference.OptimizeObjectScaling();

            DrawDefaultInspector();

            serializedObject.ApplyModifiedProperties();
        }
    }
}

