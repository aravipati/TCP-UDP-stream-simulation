package com.asynct;

import android.os.Bundle;
import android.app.Activity;
import android.view.Menu;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.net.InetAddress;
import java.net.InetSocketAddress;
import java.net.Socket;
import java.net.SocketAddress;
import java.util.Arrays;
import java.util.Calendar;

import android.app.Activity;
import android.os.AsyncTask;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.*;


public class MA extends Activity {
	Button Button1;
	EditText port,ip;
	TextView result;
	CheckedTextView cT;
	NetworkTask networktask;
	byte[] buffer = new byte[1024];
	Calendar c = Calendar.getInstance();
	int seconds= c.get(Calendar.SECOND);
	int LastSecondData=0;
	int CurrentSecondData=0;
	int T;
	int read;
	String Server_ip;
	Boolean connected=false;
	@Override
	protected void onCreate(Bundle savedInstanceState) 
	{
		super.onCreate(savedInstanceState);
		setContentView(R.layout.ma);
		Button1=(Button)findViewById(R.id.Button1);
		ip=(EditText)findViewById(R.id.ip);
		port=(EditText)findViewById(R.id.port);
		result=(TextView)findViewById(R.id.result);
		Button1.setOnClickListener(buttonConnectOnClickListener);
		
		
		}
	private OnClickListener buttonConnectOnClickListener = new OnClickListener() {
        public void onClick(View v){
            if(!connected){//if not connected
                System.out.println("connecting to Server");
                Server_ip=ip.getText().toString();
                networktask = new NetworkTask(); //New instance of NetworkTask
                networktask.execute();
            }else{
            	System.out.println("disconnecting from Server...");
                if(networktask!=null){
                    networktask.closeSocket();
                    networktask.cancel(true);
                }
            
            else
            {
            	networktask.reconnect();
            	}
            }
        }
    };
	public class NetworkTask extends AsyncTask<Void, Integer, Boolean> 
	{
        Socket nsocket; //Network Socket
        InputStream nis; //Network Input Stream
        
        protected void onPreExecute() {
            //change the connection status to "connected" when the task is started
            changeConnectionStatus(true);
        }
        
		@Override
		protected Boolean doInBackground(Void... params)
		{
			boolean res= false;
			
			try
			{
				Log.i("AsyncTask", "doInBackground: Creating socket");
				SocketAddress sockaddr = new InetSocketAddress(Server_ip.toString(),4444);
				nsocket = new Socket();
                nsocket.connect(sockaddr, 4444);
                if (nsocket.isConnected())
                {
                    nis = nsocket.getInputStream();
                    Log.i("AsyncTask", "doInBackground: Socket created, streams assigned");
                    byte[] buffer = new byte[100];
                    read = nis.read(buffer, 0, 100); //This is blocking
                    System.out.println(read);
                    while(read != -1)
                    {
                    	if(seconds!=Calendar.SECOND)
                    	{
                    		seconds= Calendar.SECOND;
                    		LastSecondData=CurrentSecondData;
                    		CurrentSecondData=0;
                    	    int T= LastSecondData/1024;
                    	    System.out.println(T);
                    	    publishProgress(T);
                            Log.i("AsyncTask", "doInBackground: Data in last second");
                            //read = nis.read(buffer, 0, 4096);
                            }
                    	else{
                    		seconds= Calendar.SECOND;
                    		LastSecondData=CurrentSecondData;
                    		//CurrentSecondData=0;
                    	    int T= LastSecondData/1024;
                    	    publishProgress(T);
                    	    System.out.println(T);
                            Log.i("AsyncTask", "doInBackground: Data in last second");
                            //read = nis.read(buffer, 0, 4096);
                    	}
                    	CurrentSecondData+=8*read;
                    	
                    }
                   
                    }
				
			}
			catch (IOException e) {
                e.printStackTrace();
                Log.i("AsyncTask", "doInBackground: IOException");
                res = true;
            } 
			finally {
				closeSocket();
				
			}
			return res;
			}
		
			public void closeSocket(){
			try 
			{
				
                read=-1;    
				nis.close();
                nsocket.close();
                System.out.println("disconnected");
                 } 
                catch (IOException e) 
                {
                    e.printStackTrace();
                }
                Log.i("AsyncTask", "doInBackground: closed");
			}
			
		
		
	protected void onProgressUpdate(Integer... a)
	{ 
		
		super.onProgressUpdate(a);
		result.setText(Integer.toString(a[0])+"kbps");
		Arrays.fill(a, null);
	}

		protected void onPostExecute(Boolean res) {
	            if (res) {
	                Log.i("AsyncTask", "onPostExecute: Completed with an Error.");
	            } else {
	                Log.i("AsyncTask", "onPostExecute: Completed.");
	            }
	            Button1.setVisibility(View.VISIBLE);
	            changeConnectionStatus(false);
	        }
		 public void changeConnectionStatus(Boolean isConnected) {
		        connected=isConnected;
		        if(isConnected){
		        	
		        	System.out.println("connected to server");
		        	}       
		        else
		        {
		        System.out.println("disconnected");
		        }
		 }
	 protected void onCancelled() {
         Log.i("AsyncTask", "Cancelled.");
         changeConnectionStatus(false);
         Button1.setVisibility(View.VISIBLE);
     }
		
		    protected void onDestroy() {
		    	if(networktask!=null)
		    	{
		    	networktask.cancel(true);
		    }
	}
		    public void reconnect() 
		    {
				// TODO Auto-generated method stub
				networktask.execute();
				result.setText("");
			}
	}
}



	

