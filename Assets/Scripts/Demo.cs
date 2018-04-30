using System;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    public Text LocalValue;
    public Text NtpValue;

    private void Update()
    {
        var dateTimeNow = DateTime.Now;
        LocalValue.text = string.Format("{0} {1}", dateTimeNow.ToShortDateString(), dateTimeNow.ToLongTimeString());

        if (NtpDateTime.Instance.DateSynchronized)
        {
            var ntpDateTimeNow = NtpDateTime.Instance.Now;
            NtpValue.text = string.Format("{0} {1}", ntpDateTimeNow.ToShortDateString(), ntpDateTimeNow.ToLongTimeString());
        }
        else
        {
            NtpValue.text = "Synchronization in progress...";
        }
    }
}