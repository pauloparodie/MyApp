pipeline {
	agent none
	
	environment {
		VAL = 'ola'
	}
	
	stages {
		stage('pre') {
			steps {
				echo 'NO BRANCH MAIN->${env.VAL}'
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
				echo '${env.BUILD_ID}->${env.JOB_NAME}:${env.BUILD_NAME}'
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


