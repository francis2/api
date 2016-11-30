# wget http://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/2.2.1/swagger-codegen-cli-2.2.1.jar -O swagger-codegen-cli.jar
java -jar swagger-codegen-cli.jar generate -i ../swagger/services.swagger.yaml \
  -l csharp \
  -o services-api \
  --additional-properties \
  packageName=Tradovate.Services,optionalProjectFile=true,excludeTests=true

cd services-api

chmod 744 build.sh

cd -
