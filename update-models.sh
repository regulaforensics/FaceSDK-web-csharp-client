DOCS_DEFINITION_FOLDER="${PWD}/../FaceSDK-web-openapi"  \
\
&& docker run --user "$(id -u):$(id -g)" --rm -v "${PWD}:/client" -v "$DOCS_DEFINITION_FOLDER:/definitions" \
openapitools/openapi-generator-cli:v5.4.0 generate \
-i /definitions/index.yml -g csharp -o /client/ \
--global-property models \
-c /client/csharp-generator-config.json
