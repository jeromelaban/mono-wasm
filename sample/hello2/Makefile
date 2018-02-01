all: hello.exe output/index.wasm output/index.html

test.test.dll: test.cs
	mcs -nostdlib -noconfig -r:../../dist/lib/mscorlib.dll -out:test.test.dll test.cs -t:library

hello.exe:      hello.cs test.test.dll
	mcs -nostdlib -noconfig -r:../../dist/lib/mscorlib.dll -r:test.test.dll hello.cs -out:hello.exe

output/index.wasm:      hello.exe
	../../dist/bin/mono-wasm -i hello.exe -o output

output/index.html:      index.html
	cp index.html output

clean:
	rm -rf build output hello.exe
