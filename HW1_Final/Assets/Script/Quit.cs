using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    // 檢測按鍵輸入
    void Update()
    {
        // 如果按下了 Esc 鍵
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // 退出應用程序
            Application.Quit();
            
            // 如果是在 Unity 編輯器中運行，停止運行
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }
    }

    // 如果你還有按鈕點擊退出功能，可以保留這個方法
    public void Click()
    {
        Application.Quit();
    }
}