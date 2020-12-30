--download: wget https://raw.githubusercontent.com/tomaschku/MC-Turtle-Remote-Control/main/MCTurtleRemoteController/MCTurtleRemoteController/Lua/Turtle.lua Turtle.lua
--docs: https://www.capgo.com/Resources/SoftwareDev/LuaShortRef51.pdf

-- Setup system
os.loadAPI("json") --pastebin get 4nRg9CHU json
--require("json") -- Behaves strangely

-- The turtles id
local turtleID = os.getComputerID()

-- Wether the turtle is connecting for the first time or just reconnecting
local firstConn = true
-- The WebSocket connected to
local ws = nil
-- The WS error if the connection was not successful
local wsErr = nil
-- Can be "broadcast", "this" (the turtle id is going to be replaced with this for simplicity) or "ignore"
local wsTarget = nil

-- Program loop
while true do
 -- Connect to WS
 ws, wsErr = http.websocket("ws://127.0.0.1/turtle")
 
 if wsErr then
  -- Show wsErr Message
  if firstConn then
   print("> wsErr Connecting: " .. wsErr)
  else
   print("> DISCONNECTED! Reconnecting... (" .. wsErr .. ")")
  end
  
 elseif ws then
  -- Successful connection
  firstConn = false
  print("> CONNECTED")
  
  -- Register turtle
  local registerMsg = {}
  registerMsg.id = turtleID
  registerMsg.type = "register"
  registerMsg.result = ""

  -- Start MSGLoop
  while true do
   --Receive & parse from WS
   local wsStr = ws.receive()
   print (wsStr) -- Debug print
   local wsCmd = json.decode(wsStr)
   
   -- Check if JSON is valid (nil = invalid)
   if wsCmd == nil then
    print("> INVALID JSON!")
   else
    -- Save the target of the msg
    if wsCmd.target == "broadcast" then
     wsTarget = "broadcast"
    elseif wsCmd.target == turtleID then
     wsTarget = "this"
    else
     wsTarget = "ignore"
    end
    
    -- Ignore unrelated messages
    if wsTarget ~= "ignore" then
     -- Execute the msg
     if wsCmd.type == "eval" then
      -- Make string a function
      local func, err = loadstring(wsCmd.code)
      
      -- If valid execute (else print err)
      if func then
       local ret = func()
       print(ret)
     
       local doneMsg = {}
       doneMsg.id = turtleID;
       doneMsg.type = "result"
       doneMsg.result = ret
     
       ws.send(json.encode(doneMsg))
      else
       print("> Error: ", err)
      end
     end
    end
   end
   
  end -- while true do (MSGLoop)
 end -- if wsErr then (WS Connection Failure)
end -- Program loop