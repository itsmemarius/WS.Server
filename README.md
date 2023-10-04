# WebSocket Client-Server Chat Application

## Introduction 🌐

This project demonstrates a WebSocket-based client-server chat application using C#. Before diving into the project details, let's understand what a socket is:

## What is a Socket? 🔌

A socket is a communication endpoint that allows two computers to establish a network connection and exchange data. It acts as a virtual "plug" in a wall socket, where data can be sent and received. Sockets are fundamental for network communication, enabling applications to communicate over the internet or within a local network.

## Telephone Conversation ☎️

Think of a socket as a telephone line between two people. Each person has a phone (socket), and they can talk to each other by dialing the other person's number. They can send messages (data) back and forth, creating a real-time conversation.

## Project Overview 📋

This project consists of two parts: a WebSocket server (`ServerApp`) and a WebSocket client (`ClientApp`).

- **ServerApp**:
  - Listens for incoming WebSocket connections on `http://localhost:8080/`.
  - Accepts WebSocket connections and processes incoming messages.
  - Echoes received messages back to the client.

- **ClientApp**:
  - Connects to the WebSocket server at `http://localhost:8080/`.
  - Allows the user to send messages to the server.
  - Displays messages received from the server.

## How It Works 🚀

1. Start the WebSocket server (`ServerApp`) on your computer. It listens for incoming connections.

2. Start the WebSocket client (`ClientApp`). It connects to the server.

3. You can type messages on the client-side and send them to the server.

4. The server receives your messages, processes them, and sends them back to the client.

5. The client displays the messages received from the server.

6. You can have a real-time chat conversation between the client and the server.

## Usage 📝

1. Build and run `ServerApp` to start the WebSocket server.

2. Build and run `ClientApp` to start the WebSocket client.

3. Follow the on-screen instructions to send and receive messages.

## Dependencies 🛠️

- .NET Core (for both server and client)

## Notes 📝

- This is a simple example for educational purposes.
- Feel free to extend and modify the code to suit your specific needs.

## Author 📅

- @itsmemarius
