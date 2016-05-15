package com.asyncu;

import android.os.Bundle;
import android.app.Activity;
//import android.app.Notification;
import android.util.Log;
import android.view.*;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.*;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;

import android.annotation.SuppressLint;
import android.os.AsyncTask;
import android.os.Build;

import java.net.InetAddress;
import java.net.SocketException;
import java.net.UnknownHostException;


public class MainActivity extends Activity {
	Button bttn;
	CheckedTextView ctv;
	TextView result;
	Button rset;
	NetworkTask networktask;
	byte[] buffer = new byte[256];
	Boolean connected=false;
	DatagramSocket ds=null;
	boolean x=true;
	static int packetCount = 0;
	byte[] p;
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		bttn=(Button)findViewById(R.id.Button1);
		result=(TextView)findViewById(R.id.result);
		bttn.setOnClickListener(buttonConnectOnClickListener);
	}
	private OnClickListener buttonConnectOnClickListener = new OnClickListener() {
        public void onClick(View v){
            if(!connected){//if not connected
                System.out.println("connecting to Server");
               networktask = new NetworkTask(); //New instance of NetworkTask
                networktask.execute();
            }
            else{
            	System.out.println("disconnecting from Server...");
                if(networktask!=null){
                    networktask.closeSocket();
                    networktask.cancel(true);
                }
            
            }
        }
    };
    public class NetworkTask extends AsyncTask<String, String, String> 
	{

    	@Override
		protected String doInBackground(String... params)
		{
			//boolean res= false;
			
			try
			{
				Log.i("AsyncTask", "doInBackground: Creating socket");
				ds=new DatagramSocket(5000);
				Log.i("AsyncTask", "doInBackground: socket created");
				 DatagramPacket recv_packet = new DatagramPacket(buffer, buffer.length);
				 packetCount = 0;
				while(x)
			      {
					//System.out.println("in while");
			       
					 Log.i("AsyncTask", "doInBackground: in while");
			        //ds.setSoTimeout(1000);
					 ds.receive(recv_packet);
			        Log.i("AsyncTask", "doInBackground: packets received");
			        packetCount++;
			        //p= recv_packet.getData();
			        //String s=new String(p);
			        //System.out.print(s);
			        publishProgress(""+packetCount);
			        Log.i("AsyncTask", "doInBackground: after publish");
			        
			       
			        
			      }
			}
			catch(RuntimeException e)
			{
				System.out.println("Error"+e.getMessage()+"\n"+e.getStackTrace().toString());
			}
			catch(Exception e)
			{
				System.out.println("Error"+e.getMessage()+"\n"+e.getStackTrace().toString());
			}
    	finally
    	{
    		closeSocket();
    	}
			return null;
	}
    	void closeSocket()
    	{
    		ds.close();
    		x=false;
    	}
    	public void onProgressUpdate(String... currentPacketCount)
    	{
    		super.onProgressUpdate(currentPacketCount);
    		Log.e("AsyncTask", "doInBackground: " + currentPacketCount.toString());
    		result.setText(""+currentPacketCount[0]);
    	}
    	
	}
    
    
}
	

	 


