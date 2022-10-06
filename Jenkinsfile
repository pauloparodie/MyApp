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
				bat("xcopy c:\\temp\\teste.txt c:\\temp\\old")
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


