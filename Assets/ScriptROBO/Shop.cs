using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Shop : MonoBehaviour
{

    public static bool ShopIsTurnedOn = false;

    [SerializeField]    TMP_Text DamageNumber;
    [SerializeField]    TMP_Text FireRateNumber;
    [SerializeField]    TMP_Text MovementSpeedNumber;

    PlayerShooting PlayerShooting;
    PlayerMovement PlayerMovement;

    
    

    float DamageUP;
    float FireRateUP;
    float MovementSpeedUP;
    float Shopcost = 1000;
    [SerializeField] float MyMoney = 0;
    




    public GameObject ShopUI;

    void FixedUpdate()
    {
        MyMoney = GameObject.Find("InGameManager").GetComponent<GameManager>().pointScore;
    }

    public void DamageUpgrade ()
    {
        


        if (MyMoney >= Shopcost)
        {
            
            DamageUP = GameObject.Find("WeaponLeft").GetComponent<PlayerShooting>().damage;
            GameObject.Find("WeaponLeft").GetComponent<PlayerShooting>().damage += 1f;
            GameObject.Find("InGameManager").GetComponent<GameManager>().pointScore -= Shopcost;
        }

    }
    public void FireRateUpgrade()
    {
        if (MyMoney >= Shopcost)
        {

            FireRateUP = GameObject.Find("WeaponLeft").GetComponent<PlayerShooting>().Firerate;
            GameObject.Find("WeaponLeft").GetComponent<PlayerShooting>().Firerate += 5f;
            GameObject.Find("InGameManager").GetComponent<GameManager>().pointScore -= Shopcost;
        }

    }
    public void MovementSpeedUpgrade()
    {



        if (MyMoney >= Shopcost)
        {

            MovementSpeedUP = GameObject.Find("FPSRigi").GetComponent<RigidbodyMovement>().Speed;
            GameObject.Find("FPSRigi").GetComponent<RigidbodyMovement>().Speed += 3f;
            GameObject.Find("InGameManager").GetComponent<GameManager>().pointScore -= Shopcost;
        }

    }








    // Update is called once per frame
    void Update()
    {
        DamageNumber.text = Mathf.FloorToInt(GameObject.Find("WeaponLeft").GetComponent<PlayerShooting>().damage).ToString();
        FireRateNumber.text = Mathf.FloorToInt(GameObject.Find("WeaponLeft").GetComponent<PlayerShooting>().Firerate).ToString();
        MovementSpeedNumber.text = Mathf.FloorToInt(GameObject.Find("FPSRigi").GetComponent<RigidbodyMovement>().Speed).ToString();








        if (Input.GetKeyDown(KeyCode.E))
        {

            if (ShopIsTurnedOn)
            {
                OpenShop();
            }
            else
            {
                CloseShop();
            }
        }
    }


    public void OpenShop()
    {
        Cursor.lockState = CursorLockMode.Locked;
        ShopUI.SetActive(false);
        ShopIsTurnedOn = false;
        GameObject.Find("FPSRigi").GetComponent<RigidbodyMovement>().enabled = true;
        GameObject.Find("WeaponLeft").GetComponent<PlayerShooting>().enabled = true;

    }


    public void CloseShop()
    {
        Cursor.lockState = CursorLockMode.None;
        ShopUI.SetActive(true);
        ShopIsTurnedOn = true;
        GameObject.Find("FPSRigi").GetComponent<RigidbodyMovement>().enabled = false;
        GameObject.Find("WeaponLeft").GetComponent<PlayerShooting>().enabled = false;

    }










}