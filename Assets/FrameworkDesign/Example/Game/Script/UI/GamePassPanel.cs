﻿using UnityEngine;
using UnityEngine.UI;

namespace FrameworkDesign.Example
{
    public class GamePassPanel : MonoBehaviour, IController
    {
        private void OnEnable()
        {
            transform.Find("RemainSecondsText").GetComponent<Text>().text =
                "剩余时间:" + this.GetSystem<ICountDownSystem>().CurrentRemainSeconds + "s";

            var gameModel = this.GetModel<IGameModel>();

            transform.Find("BestScoreText").GetComponent<Text>().text =
                "最高分数:" + gameModel.BestScore.Value;

            transform.Find("ScoreText").GetComponent<Text>().text =
                "分数:" + gameModel.Score.Value;
        }
        

        public IArchitecture GetArchitecture()
        {
            return PointGame.Instance;
        }
    }

}