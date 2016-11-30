frameworkVersion=net45
netfx=${frameworkVersion#net}

echo "[INFO] Target framework: ${frameworkVersion}"

echo "[INFO] Copy DLLs to the 'bin' folder"
mkdir -p bin;
cp ../services-api/bin/*.dll bin;

echo "[INFO] Run 'mcs' to build bin/Tradovate.Services.dll"
mcs -sdk:${netfx} -r:bin/Newtonsoft.Json.dll,\
bin/RestSharp.dll,\
bin/Websocket4Net.dll,\
bin/Tradovate.Services.dll,\
System.Runtime.Serialization.dll \
-target:exe \
-out:bin/Sample.exe \
-recurse:'src/*.cs' \
-platform:anycpu

if [ $? -ne 0 ]
then
  echo "[ERROR] Compilation failed with exit code $?"
  exit 1
else
  echo "[INFO] bin/Sample.exe was created successfully"
fi
