dotnet build ./src/Regula.FaceSDK.NetCoreExample -c Release

cd  ./src/Regula.FaceSDK.NetCoreExample || exit

export API_BASE_PATH="https://nightly-faceapi.regulaforensics.com"

dotnet run
