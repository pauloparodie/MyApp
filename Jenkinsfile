pipeline {
	agent none
	
	environment {
		VAL = "ola"
	}
	
	stages {
		stage('pre') {
			agent any
			steps {
				echo "NO BRANCH MAIN->${env.VAL}"
				bat("git config --global --add safe.directory D:/Projectos/Testes/MyApp ")
				bat("git -C d:\\projectos\\testes\\myapp status")
			}
		}
		stage('pre2') {
			when {
				expression {
					env.VAL == "ola"
				}
			}
			steps {
				echo "----->IGUAL"
			}
		}
		stage('checkout') {
			agent any
			steps {
				checkout scm
			}		
		}
		stage('build') {
			steps {
				echo "${env.BUILD_ID}->${env.JOB_NAME}:${env.BUILD_NAME}"
				msbuild myapp/myapp.csproj
			}
		}
	}
	
	post {
		success {
			echo 'Sucesso'
		}
		failure {
			echo 'Erro'
		}
	}
}


