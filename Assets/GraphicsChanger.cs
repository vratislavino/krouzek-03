using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicsChanger : MonoBehaviour
{
    List<PlayerControls> selectedPlayers = new List<PlayerControls>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SelectPlayer(PlayerControls player) {

        if(selectedPlayers.Contains(player)) {
            UnselectPlayer(player);
        } else {
            selectedPlayers.Add(player);
            player.isSelected = true;
            player.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }

    public void UnselectPlayer(PlayerControls player) {
        player.isSelected = false;
        selectedPlayers.Remove(player);
        player.GetComponent<MeshRenderer>().material.color = Color.white;
    }
}
