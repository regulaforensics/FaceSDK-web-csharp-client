DOCS_DEFINITION_FOLDER="${PWD}/../FaceRecognition-web-openapi"  \
\
&& ENUM_MAPPINGS="ImageSource=int,FaceRecognitionResultCode=int,LivenessStatus=int" \
\
&& docker run --user "$(id -u):$(id -g)" --rm -v "${PWD}:/client" -v "$DOCS_DEFINITION_FOLDER:/definitions" \
openapitools/openapi-generator-cli:v5.0.0-beta2 generate \
-i /definitions/index.yml -g csharp -o /client/ \
-c /client/csharp-generator-config.json -t /client/generator-templates/ \
\
&& docker run --user "$(id -u):$(id -g)" --rm -v "${PWD}:/client" -v "${DOCS_DEFINITION_FOLDER}:/definitions" \
openapitools/openapi-generator-cli:v5.0.0-beta2 generate \
-i /definitions/index.yml -g csharp -o /client/ \
-c /client/csharp-generator-config.json -t /client/generator-templates/ \
--import-mappings $ENUM_MAPPINGS