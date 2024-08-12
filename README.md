<h1> ASP.NET Core Web API with Firebase Push Notifications </h1>

<h4> Overview </h4>
<p> This project is an ASP.NET Core Web API that allows you to send push notifications to clients using <strong>Firebase Cloud Messaging (FCM)</strong>. 
  The API receives a token from a client and sends push notifications to that client through <strong>Firebase</strong>.
</p>

<h4> Features </h4>
<ul>
  <li>Receive client tokens</li>
  <li>Send push notifications to clients using Firebase</li>
  <li>Manage Firebase configuration</li>
</ul>

<h4> Prerequisites </h4>
<ul>
  <li>.NET SDK 8.0 or later</li>
  <li>Firebase Project with Cloud Messaging enabled</li>
  <li>Firebase Admin SDK</li>
</ul>

<h4> Setup </h4>
Clone the Repository <p></p>
<div class="codehilite">
<pre><code> 
    git clone https://github.com/your-repo/your-project.git <br>
    cd your-project
</code></pre>
</div>

Install Dependencies
<p></p>
<div class="codehilite">
<pre><code> 
    dotnet restore
</code></pre>
</div>

Configure Firebase
<ul>
  <li>Create a Firebase project in the Firebase Console.</li>
  <li>Navigate to Project Settings > Service accounts.</li>
  <li>Generate a new private key and save the serviceAccountKey.json file.</li>  
</ul>

<h4>Contact</h4>
For questions or feedback, please contact athandar1998@gmail.com.
