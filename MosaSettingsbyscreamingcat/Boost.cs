using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;
using BepInEx;
using GorillaLocomotion;
using GorillaNetworking;
using HarmonyLib;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;
using Photon.Realtime;



namespace MosaSettingsbyscreamingcat
{

    [BepInPlugin("com.Screamingcats.MosaBoost", "MosaBoostOrSettings", "1.0.0")]

    public class Boost : BaseUnityPlugin
    {
        public void Update()
        {
            GorillaLocomotion.Player.Instance.maxJumpSpeed = 7.4f;
            GorillaLocomotion.Player.Instance.jumpMultiplier = 1.2f;


            Text real = GameObject.Find("motdtext").GetComponent<Text>();

            
            string ping = PhotonNetwork.NetworkClientState == ClientState.Joined ? PhotonNetwork.GetPing().ToString() : "NOT IN LOBBY";
            string lobbyCode = PhotonNetwork.CurrentRoom != null ? PhotonNetwork.CurrentRoom.Name : "NOT IN LOBBY";
            bool inLobby = PhotonNetwork.InLobby;



           
            string frtghfjk = $"<color=red>THANKS FOR USING SCREAMINGCATS MOSA BOOST SETTINGS, THIS IS CURRENTLY A TEST SOOO YURRR\n\n</color>" +$"<color=blue>YOUR PING: {ping}\n" +$"LOBBY CODE: {lobbyCode}\n" +$"IN LOBBY: {inLobby}</color>";


            real.text = frtghfjk;

        }
    }

}
